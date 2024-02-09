using BusinessObjects.Entity;

namespace Services.Services
{
    public interface ICatalogService
    {
        public Task ShowCatalog();

        public Task<IEnumerable<Book>> GetBooks();

        public Task<Book> FindBook(int id);

        public Task<IEnumerable<Book>> GetFantasyBooks();

        public Task<IEnumerable<Book>> GetBooksByType(string type);

        public Task<Book> GetBetterGradeBook();
    }
}
