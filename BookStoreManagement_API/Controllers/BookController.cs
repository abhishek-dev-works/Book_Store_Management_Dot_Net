using Microsoft.AspNetCore.Mvc;
using BookStoreManagement_Application.Interfaces;

namespace BookStoreManagement_API.Controllers
{
    [ApiController]
    [Route("api/books")] // Base route
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookService bookService, ILogger<BookController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpGet("{id}")] // GET api/books/{id}
        public IActionResult GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                _logger.LogWarning($"Book with ID {id} not found.");
                return NotFound(new { message = "Book not found" });
            }
            return Ok(book);
        }

        [HttpGet] // GET api/books
        public IActionResult GetAllBooks()
        {
            List<Book> books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpPost] // POST api/books
        public IActionResult AddNewBook([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest(new { message = "Invalid book data" });
            }

            _bookService.AddNewBook(book);
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }
    }
}
