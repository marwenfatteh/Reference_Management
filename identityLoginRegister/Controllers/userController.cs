using AutoMapper;
using identityLoginRegister.Dtos.Account;
using identityLoginRegister.Interfaces;
using identityLoginRegister.Models;
using identityLoginRegister.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace identityLoginRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public userController(IUserRepository userRepository, IMapper mapper, UserManager<User> userManager )
        {
            _UserRepository = userRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]

        public IActionResult GetUsers()
        {
            var users = _mapper.Map<List<UserDto>>( _UserRepository.GetUsers() );

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(users);
        }

        [HttpGet("{userId}")]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(400)]
        public IActionResult GetUser(string userId)
        {
            if(!_UserRepository.UserExists(userId))
                return NotFound();
            var user = _mapper.Map<UserDto>( _UserRepository.GetUser(userId) );
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);
        }


        [HttpDelete("{userId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteUser(string userId)
        {
            if (!_UserRepository.UserExists(userId))
            {
                return NotFound();
            }
            var userToDelete = _UserRepository.GetUser(userId);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (!_UserRepository.DeleteUser(userToDelete))
            {
                ModelState.AddModelError("", "Something went wrong deleting user");
            }
            return NoContent();
        }


    }



}
