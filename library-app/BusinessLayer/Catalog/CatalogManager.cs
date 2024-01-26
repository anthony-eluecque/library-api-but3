using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private BookRepository _bookRepository = new BookRepository();

        public void DisplayCatalog()
        {
            List<Book> books = _bookRepository.GetAll().ToList();

            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
            }
        }

        public Book FindBook(int id)
        {
            return _bookRepository.Get(id).First();
        }

        public List<Book> GetFantasyBooks()
        {
            //List<Book> books = _bookRepository.GetAll().ToList();
            //return books.FindAll(book => book.Type == BookTypes.FANTASY);
            return new List<Book>();
        }
    }
}
