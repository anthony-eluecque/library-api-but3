using BusinessObjects.Entity;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : ARepository<Author>
    {
        public AuthorRepository(DataContext context) : base(context)
        {
        }
    }
}
