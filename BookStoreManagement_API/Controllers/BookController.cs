using Microsoft.AspNetCore.Mvc;

namespace BookStoreManagement_API.Controllers
{
    [ApiController]
    [Route("api/books")] // <-- Unique base route
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        public BookController(ILogger<BookController> logger) { _logger = logger; }

        [HttpGet("{id}")] // <-- Relative route (api/books/{id})
        public IActionResult GetBookById(int id)
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
