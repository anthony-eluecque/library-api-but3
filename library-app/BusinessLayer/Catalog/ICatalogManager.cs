using BusinessObjects.Entity;

namespace BusinessLayer.Catalog
{
    public interface ICatalogManager
    {
        public Task DisplayCatalog();

        public Task<Book> FindBook(int id);

        public Task<IEnumerable<Book>> GetFantasyBooks();
    }
}
