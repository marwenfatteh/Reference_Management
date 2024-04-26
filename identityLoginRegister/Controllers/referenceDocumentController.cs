﻿using AutoMapper;
using identityLoginRegister.Dtos.Account;
using identityLoginRegister.Dtos.References;
using identityLoginRegister.Interfaces;
using identityLoginRegister.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.IO.Pipes;
using System.Security.Claims;
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
            if (file == null || file.Length == 0)
                return BadRequest("File is not selected or empty.");

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
            if (!_referenceDocumentRepository.CreateReferenceDocument(referenceDocumentMap))
            {
                ModelState.AddModelError("", "sthg went wrong while saving");
                return StatusCode(500, ModelState);
            }
            return Ok("success");
        }

        [Authorize]
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
