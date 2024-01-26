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


        public void FindBook(int id);
    }
}
