using Microsoft.AspNetCore.Mvc;

namespace BookStoreManagement_API.Controllers
{
    public class RecordController: ControllerBase
    {
        private readonly ILogger<RecordController> _logger;
        public RecordController(ILogger<RecordController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult GetAllEntries()
        {
            return Ok();
        }
        [HttpPost]
        [Route("/add")]
        public IActionResult AddNewEntry()
        {
            return Ok();
        }
        [HttpPut]
        [Route("/{id}")]
        public IActionResult UpdateEntryById()
        {
            return Ok();
        }
        [HttpGet]
        [Route("/{id}")]
        public IActionResult GetEntriesByUserId()
        {
            return Ok();
        }

    }
}
