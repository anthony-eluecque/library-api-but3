using BusinessObjects.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace LibraryManager.Hosting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICatalogService _catalogService;

        public BookController(ILogger<WeatherForecastController> logger, ICatalogService catalogService)
        {
            _logger = logger;
            _catalogService = catalogService;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Book>> Get()
        {
            return await _catalogService.GetBooks();
        }


        [HttpGet("book/{id:int}")]
        public async Task<ActionResult<Book>> GetById(int id)
        {
            return await _catalogService.FindBook(id);
        }

        [HttpGet("{type}")]
        public async Task<IEnumerable<Book>> GetByType(string type)
        {
            return await _catalogService.GetBooksByType(type);
        }


        [HttpGet("topRatedBook")]
        public async Task<ActionResult<Book>> GetTopRatedBook()
        {
            return await _catalogService.GetBetterGradeBook();
        }

    }
}
