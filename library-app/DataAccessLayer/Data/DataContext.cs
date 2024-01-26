using BusinessObjects.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Book> Book => Set<Book>();

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }


    }
}
