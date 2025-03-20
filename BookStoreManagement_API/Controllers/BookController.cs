using Microsoft.AspNetCore.Mvc;

namespace BookStoreManagement_API.Controllers
{
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("/{id}")]
        public IActionResult GetBookById()
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllBooks() 
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddNewBook()
        {
            return BadRequest();
        }
    }
}
