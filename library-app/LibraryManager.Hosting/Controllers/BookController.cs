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


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            return await _catalogService.FindBook(id);
        }
    }
}
