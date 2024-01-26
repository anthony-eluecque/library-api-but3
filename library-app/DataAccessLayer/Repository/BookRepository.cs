using BusinessObjects.Entity;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IRepository<Book>
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAll()
        {
            try
            {
                Console.WriteLine(_context.Book);
                return await _context.Book.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<Book> Get(int id) => await _context.Book.FindAsync(id);

    }
}
