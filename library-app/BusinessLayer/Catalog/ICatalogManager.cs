using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Catalog
{
    public interface ICatalogManager
    {
        public void DisplayCatalog();


        public Book FindBook(int id);

        public List<Book> GetFantasyBooks();

        public Book GetBetterGradeBook();
    }
}
