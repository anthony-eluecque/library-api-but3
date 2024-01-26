using BusinessObjects.Entity;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository : IRepository<Library>
    {
        public Task<Library> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Library>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
