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
        
    
    
    }
}
