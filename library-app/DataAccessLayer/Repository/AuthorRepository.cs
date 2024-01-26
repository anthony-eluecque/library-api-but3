using BusinessObjects.Entity;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IRepository<Author>
    {
        public Task<Author> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Author>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
