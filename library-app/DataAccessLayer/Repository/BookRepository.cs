using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IRepository<Book>
    {

        public IEnumerable<Book> Get(int id)
        {
            yield return _books.FirstOrDefault(book => book.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }


        private List<Book> _books = new List<Book>();
    }
}
