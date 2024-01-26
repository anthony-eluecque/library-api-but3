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

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public IEnumerable<Book> Get(int id)
        {
            return _books.Where(book => book.Id == id);
        }



    }
}
