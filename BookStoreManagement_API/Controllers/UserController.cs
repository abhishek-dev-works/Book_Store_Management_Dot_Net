using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace BookStoreManagement_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger) 
        { 
            _logger = logger;
        }
        [HttpGet]
        [Route("/{id}")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult CreateUser()
        {
            return BadRequest();
        }

        [HttpGet]
        [Route("/users")]
        public IActionResult GetAllUsers() 
        {
            return Ok();
        }
    }
}
