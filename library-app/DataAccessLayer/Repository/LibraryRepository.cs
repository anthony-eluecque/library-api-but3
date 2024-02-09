using BusinessObjects.Entity;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository : ARepository<Library>
    {
        public LibraryRepository(DataContext context) : base(context)
        {
        }
    }
}
