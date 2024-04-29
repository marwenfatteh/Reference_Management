using AutoMapper;
using identityLoginRegister.Dtos.Account;
using identityLoginRegister.Dtos.References;
using identityLoginRegister.Interfaces;
using identityLoginRegister.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.TelemetryCore.TelemetryClient;
using Microsoft.SqlServer.Server;
using RestSharp;
using System.IO;
using System.IO.Pipes;
using System.Security.Claims;
using System.Security.Cryptography.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace identityLoginRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class referenceDocumentController : ControllerBase
    {
        private readonly IReferenceDocumentRepository _referenceDocumentRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public referenceDocumentController(IReferenceDocumentRepository referenceDocumentRepository, IMapper mapper, UserManager<User> userManager)
        {
            _referenceDocumentRepository = referenceDocumentRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        /*[Authorize(Roles = "Employee")]*/
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateReferenceDocumentAsync(IFormFile file)
        {
            /*if (file == null || file.Length == 0)
                return BadRequest("File is not selected or empty.");*/

            var user = await _userManager.GetUserAsync(HttpContext.User);

            var refdoc = new referenceDocumentDto
            {
                Title = file.FileName,
                userId = user.Id
            };
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                refdoc.referenceDocument = memoryStream.ToArray();
            }


            var referenceDocumentMap = _mapper.Map<ReferenceDocument>(refdoc);


            var client = new RestClient("http://127.0.0.1:5000");
            var request = new RestRequest("/ask", Method.Post)
            {
                AlwaysMultipartFormData = true
            };

            var options = new FileParameterOptions
            {
                DisableFilenameEncoding = true,
                DisableFileNameStar = false
            };

            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("file", refdoc.referenceDocument, refdoc.Title, "application/pdf");
            request.AddParameter("Project", refdoc.Title); 
            


            if (!_referenceDocumentRepository.CreateReferenceDocument(referenceDocumentMap))
            {
                ModelState.AddModelError("", "sthg went wrong while saving");
                return StatusCode(500, ModelState);
            }
            request.AddParameter("Id", referenceDocumentMap.Id);
            client.Post(request);
            request.AddParameter("Id", referenceDocumentMap.Id);
            client.Post(request);
            return Ok("success");
            
        }

        

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetReferenceDocument(string Id)
        {
            var fs = await _referenceDocumentRepository.GetReferenceDocument(Id);
            if (fs == (null,null))
                return NotFound();
            string contentType = "application/pdf";
            return File(fs.Item1, contentType, fs.Item2);





        }





    }
}
