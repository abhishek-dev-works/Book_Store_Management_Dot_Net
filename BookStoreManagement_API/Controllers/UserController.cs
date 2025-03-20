using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace BookStoreManagement_API.Controllers
{
    [ApiController]
    [Route("api/users")] // <-- Unique base route
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger) { _logger = logger; }

        [HttpGet("{id}")] // <-- Relative route (api/users/{id})
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost("create")] // <-- Relative route (api/users/create)
        public IActionResult CreateUser()
        {
            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok();
        }
    }

}
