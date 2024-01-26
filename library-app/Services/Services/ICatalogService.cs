using BusinessObjects.Entity;

namespace Services.Services
{
    public interface ICatalogService
    {
        public Task ShowCatalog();

        public Task<Book> FindBook(int id);

        public Task<IEnumerable<Book>> GetFantasyBooks();
    }
}
