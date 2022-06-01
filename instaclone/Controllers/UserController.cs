using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using instaclone.Dtos;
using instaclone.Services.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace instaclone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("RegisterUser")]
        public async Task<IActionResult> RegisterUser(UserRegisterDto model)
        {
            try
            {
                UserDto userDto = await _userService.RegisterUser(model);
                return Ok(userDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
