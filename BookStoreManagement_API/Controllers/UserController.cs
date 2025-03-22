using Microsoft.AspNetCore.Mvc;
using BookStoreManagement_Application.Interfaces;

namespace BookStoreManagement_API.Controllers
{
    [ApiController]
    [Route("api/users")] // <-- Base route
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpGet("{id}")] // GET api/users/{id}
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                _logger.LogWarning($"User with ID {id} not found.");
                return NotFound(new { message = "User not found" });
            }
            return Ok(user);
        }

        [HttpPost("create")] // POST api/users/create
        public IActionResult CreateUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest(new { message = "Invalid user data" });
            }

            _userService.CreateUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        [HttpGet] // GET api/users
        public IActionResult GetAllUsers()
        {
            List<User> users = _userService.GetAllUsers();
            return Ok(users);
        }
    }
}
