using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Data;

namespace Services.Services
{
    public class CatalogService : ICatalogService
    {
        private ICatalogManager _catalogManager;


        public CatalogService(ICatalogManager catalogManager) 
        { 
            _catalogManager = catalogManager;
        }   

        public async Task ShowCatalog()
        {
            await _catalogManager.DisplayCatalog();
        }

        public async Task<Book> FindBook(int id)
        {
            return await _catalogManager.FindBook(id);
        }
        
        public async Task<IEnumerable<Book>> GetFantasyBooks() => await _catalogManager.GetFantasyBooks();

        public async Task<Book> GetBetterGradeBook() => await _catalogManager.GetBetterGradeBook();

        public async Task<IEnumerable<Book>> GetBooks() => await _catalogManager.GetBooks();

        public async Task<IEnumerable<Book>> GetBooksByType(string type) => await _catalogManager.GetBooksByType(type);

        public async Task<bool> UpdateBook(Book book) => await _catalogManager.UpdateBook(book);

        public async Task<bool> DeleteBook(int id) => await _catalogManager.DeleteBook(id);

        public async Task<bool> AddBook(Book book) => await _catalogManager.AddBook(book);
        
            
    }
}
