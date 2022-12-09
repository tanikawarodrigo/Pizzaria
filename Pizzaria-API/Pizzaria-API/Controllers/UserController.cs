using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Service.IService;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Pizzaria_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("")]
        public async Task<ActionResult<User>> GetUserByCpf(string cpf)
        {
            try
            {
                var result = await _userService.GetUserByCpf(cpf);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet("list")]
        public async Task<ActionResult<List<User>>> GetUsers(int skip,int take)
        {
            try
            {
                var result = await _userService.GetAllUser(skip, take);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpPost("register")]
        public async Task<ActionResult<bool>> RegisterUser([FromBody] UserDTO userReq)
        {
            try
            {
                var result = await _userService.CreateUser(userReq);
                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
