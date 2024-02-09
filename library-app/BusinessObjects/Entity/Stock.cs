using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entity
{
    public class Stock : Entity
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int LibraryId { get; set; }
        public Library Library { get; set; }

        public int Quantity { get; set; }
    }
}
