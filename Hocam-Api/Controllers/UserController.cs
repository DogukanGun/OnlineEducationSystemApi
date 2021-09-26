using Hocam.Core.Service.Models;
 using Hocam.Core.Service.Modules.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hocam.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
 
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public UserModel Get()
        {
            return _userService.GetLoggedInUser();
        }

        // POST api/<UserController>
        [HttpPost("register")]
        [AllowAnonymous]
        public void RegisterUser([FromBody] UserRegisterModel userRegisterModel)
        {
            _userService.RegisterUser(userRegisterModel);
        }

           

        [HttpDelete]
        public void DeleteUser()
        {
            _userService.DeleteUser();
        } 
    }
}
