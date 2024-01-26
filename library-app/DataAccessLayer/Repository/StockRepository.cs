using BusinessObjects.Entity;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class StockRepository : IRepository<Stock>
    {
        public Task<Stock> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Stock>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
