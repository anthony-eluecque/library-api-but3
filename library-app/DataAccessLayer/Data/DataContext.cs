using BusinessObjects.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DataAccessLayer.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Book> Book => Set<Book>();
        public DbSet<Author> Author => Set<Author>();
        public DbSet<Library> Library => Set<Library>();

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(a => a.Id_Author)
                .IsRequired();



            modelBuilder.Entity<Book>()
                .HasMany(b => b.Stocks)
                .WithOne(s => s.Book);

            modelBuilder.Entity<Library>()
                .HasMany(l => l.Stocks)
                .WithOne(s => s.Library);

        }
    }
}
