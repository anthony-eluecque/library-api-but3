using BusinessObjects.Entity;
using DataAccessLayer.Data;
using DataAccessLayer.Repository;


namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private BookRepository _bookRepository;

        public CatalogManager(DataContext context)
        {
            _bookRepository = new BookRepository(context);
        }

        public async Task DisplayCatalog()
        {
            List<Book> books = await _bookRepository.GetAll();
            Console.WriteLine("Voici la liste des livres actuels :");
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
            }
        }

        public async Task<Book> FindBook(int id)
        {
            Book book = await _bookRepository.Get(id);
            Console.WriteLine($"Book with ID {book.Id} {book.Name}");
            return book;
        }

        public async Task<IEnumerable<Book>> GetFantasyBooks()
        {
            List<Book> books = await _bookRepository.GetAll();
            books.FindAll(book => book.Type == BookTypes.FANTASY);

            Console.WriteLine("Voici la liste des livres actuels de type fantasy");
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
            }
            return books;
        }
    }
}
