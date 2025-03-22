using Microsoft.AspNetCore.Mvc;
using BookStoreManagement_Application.Interfaces;
using BookStoreManagement_Application.Dto;
using BookStoreManagement_Application.Commands;

namespace BookStoreManagement_API.Controllers
{
    [ApiController]
    [Route("api/records")] // Base route
    public class RecordController : ControllerBase
    {
        private readonly IRecordService _recordService;
        private readonly ILogger<RecordController> _logger;

        public RecordController(IRecordService recordService, ILogger<RecordController> logger)
        {
            _recordService = recordService;
            _logger = logger;
        }

        [HttpGet] // GET api/records
        public IActionResult GetAllEntries()
        {
            List<RecordResponseDto> records = _recordService.GetAllEntries();
            return Ok(records);
        }

        [HttpPost("add")] // POST api/records/add
        public IActionResult AddNewEntry([FromBody] RecordCommand record)
        {
            if (record == null)
            {
                return BadRequest(new { message = "Invalid record data" });
            }

            _recordService.AddNewEntry(record);
            return CreatedAtAction(nameof(GetAllEntries), record);
        }

        [HttpPut("{id}")] // PUT api/records/{id}
        public IActionResult UpdateEntryById(int id, [FromBody] RecordCommand record)
        {
            if (record == null)
            {
                return BadRequest(new { message = "Invalid record data" });
            }

            _recordService.UpdateEntryById(id, record);
            return NoContent();
        }

        [HttpGet("user/{id}")] // GET api/records/user/{id}
        public IActionResult GetEntriesByUserId(int id)
        {
            List<RecordResponseDto> userRecords = _recordService.GetEntriesByUserId(id);

            if (userRecords == null || userRecords.Count == 0)
            {
                _logger.LogWarning($"No records found for user ID {id}");
                return NotFound(new { message = "No records found for this user" });
            }

            return Ok(userRecords);
        }

        [HttpPost("entries")]
        public IActionResult AddMultipleEntries([FromBody] MultipleRecordsCommand command)
        {
            try
            {
                _recordService.AddMultipleEntriesForUser(command);
                return Ok(new { message = "Records added successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("filter")]
        public IActionResult GetRecordsByFilters([FromBody] RecordsFilterCommand filter)
        {
            var records = _recordService.GetRecordsByFilters(filter);
            return Ok(records);
        }


    }
}
