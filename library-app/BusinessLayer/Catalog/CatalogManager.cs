using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private BookRepository _bookRepository = new BookRepository();

        public void DisplayCatalog()
        {
            List<Book> books = _bookRepository.GetAll().ToList();
            Console.WriteLine("Voici la liste des livres actuels :");
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
            }
        }

        public Book FindBook(int id)
        {
            Book book = _bookRepository.Get(id).First();
            Console.WriteLine($"Book with ID {book.Id} {book.Name}");
            return book;
        }

        public List<Book> GetFantasyBooks()
        {
            List<Book> books = _bookRepository.GetAll().ToList();

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

        public Book GetBetterGradeBook()
        {
            List<Book> books = _bookRepository.GetAll().ToList();

            Book book = books.OrderByDescending(book => book.Rate).First();

            Console.WriteLine($"Le livre avec la meilleure note est {book.Name} avec une note de {book.Rate}");

            return book;
        }
    }
}
