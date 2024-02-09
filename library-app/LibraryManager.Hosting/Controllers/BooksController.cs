using BusinessObjects.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using System.ComponentModel;

namespace LibraryManager.Hosting.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;
        private readonly ICatalogService _catalogService;

        public BooksController(ILogger<BooksController> logger, ICatalogService catalogService)
        {
            _logger = logger;
            _catalogService = catalogService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Book>>> Get()
        {
            return Ok(await _catalogService.GetBooks());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> GetById(int id)
        {
            var book = await _catalogService.FindBook(id);

            if (book == null) return NotFound();

            return Ok(book);
        }

        [HttpGet("{type}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetByType(string type)
        {
            if (string.IsNullOrEmpty(type) || !Enum.IsDefined(typeof(BookTypes), type.ToUpper()))
            {
                return BadRequest("Invalid book type.");
            }

            return Ok(await _catalogService.GetBooksByType(type));
        }


        [HttpGet("topRatedBook")]
        public async Task<ActionResult<Book>> GetTopRatedBook()
        {
            return Ok(await _catalogService.GetBetterGradeBook());
        }


        [HttpPut]
        public async Task<ActionResult> UpdateBook([FromBody] Book book)
        {
            bool hasBeenUpdated = await _catalogService.UpdateBook(book);
            if (hasBeenUpdated) return Ok();
            return BadRequest("Invalid book");
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBook(int id)
        {
            bool hasBeenDeleted = await _catalogService.DeleteBook(id);
            if (hasBeenDeleted) return Ok();
            return BadRequest("Invalid book");
        }

        [HttpPost("")]
        public async Task<ActionResult> CreateBook([FromBody] Book book)
        {
            bool hasBeenCreated = await _catalogService.AddBook(book);
            if (hasBeenCreated) return Ok();
            return BadRequest("Invalid book");
        }

    }
}
