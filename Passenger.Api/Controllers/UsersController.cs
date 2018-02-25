using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Dto;
using Passenger.Infrastructure.Services;

namespace Passenger.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public UserDto Get(string email)
        {
            var user = _userService.Get(email);

            return user;
        }
    }
}