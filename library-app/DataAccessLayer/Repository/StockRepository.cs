using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    internal class StockRepository : IRepository<Stock>
    {
        public IEnumerable<Stock> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
