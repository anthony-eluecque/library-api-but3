using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface ICatalogService
    {
        public void ShowCatalog();

        public Book FindBook(int id);

        public List<Book> GetFantasyBooks();
    }
}
