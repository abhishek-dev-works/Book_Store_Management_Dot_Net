using Microsoft.AspNetCore.Mvc;

namespace BookStoreManagement_API.Controllers
{
    [ApiController]
    [Route("api/records")] // <-- Unique base route
    public class RecordController : ControllerBase
    {
        private readonly ILogger<RecordController> _logger;
        public RecordController(ILogger<RecordController> logger) { _logger = logger; }

        [HttpGet]
        public IActionResult GetAllEntries()
        {
            return Ok();
        }

        [HttpPost("add")] // <-- Relative route (api/records/add)
        public IActionResult AddNewEntry()
        {
            return Ok();
        }

        [HttpPut("{id}")] // <-- Relative route (api/records/{id})
        public IActionResult UpdateEntryById(int id)
        {
            return Ok();
        }

        [HttpGet("user/{id}")] // <-- Unique relative route (api/records/user/{id})
        public IActionResult GetEntriesByUserId(int id)
        {
            return Ok();
        }
    }

}
