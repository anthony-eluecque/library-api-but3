using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IRepository<Book>
    {
        private List<Book> _books = new List<Book>();

        public BookRepository()
        {
            AddBook(new Book { Name = "Book 1", Pages = 200, Type = BookTypes.ENSEIGNEMENT, Rate = 4, Id_author = 1 , Id = 1});
            AddBook(new Book { Name = "Book 2", Pages = 150, Type = BookTypes.HISTOIRE, Rate = 5, Id_author = 2 , Id = 2});
            AddBook(new Book { Name = "Book 3", Pages = 200, Type = BookTypes.FANTASY, Rate = 4, Id_author = 1, Id = 1 });
            AddBook(new Book { Name = "Book 4", Pages = 150, Type = BookTypes.FANTASY, Rate = 5, Id_author = 2, Id = 2 });
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public IEnumerable<Book> Get(int id)
        {
            return _books.Where(book => book.Id == id);
        }


        private void AddBook(Book book)
        {
            _books.Add(book);
        }


    }
}
