using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Data;

namespace Services.Services
{
    public class CatalogService : ICatalogService
    {
        private CatalogManager _catalogManager;


        public CatalogService(DataContext context) 
        { 
            _catalogManager = new CatalogManager(context);
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
        
    
    
    }
}
