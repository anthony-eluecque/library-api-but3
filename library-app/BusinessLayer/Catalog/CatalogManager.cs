using BusinessObjects.Entity;
using DataAccessLayer.Data;
using DataAccessLayer.Repository;


namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private IRepository<Book> _bookRepository;

        public CatalogManager(IRepository<Book> repository)
        {
            _bookRepository = repository;
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

            IEnumerable<Book> booksQuery =
                from book in books
                where book.Type == BookTypes.FANTASY
                select book;

            Console.WriteLine("Voici la liste des livres actuels de type fantasy");
            foreach (Book book in booksQuery)
            {
                Console.WriteLine(book.Name);
            }
            return books;
        }

        public async Task<Book> GetBetterGradeBook()
        {
            List<Book> books = await _bookRepository.GetAll();

            Book book = books.OrderByDescending(book => book.Rate).First();

            Console.WriteLine($"Le livre avec la meilleure note est {book.Name} avec une note de {book.Rate}");

            return book;
        }
    }
}
