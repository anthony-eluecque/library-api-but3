using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public abstract class ARepository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;

        public ARepository(DataContext context)
        {
            _context = context;
        }

        public async Task<T> Get(int id) 
        {
            try 
            {
                return await _context.Set<T>().FindAsync(id);
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        public async Task<List<T>> GetAll()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            } catch (Exception ex)
            {
                throw;
            }
        }

        public async Task Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            } catch (Exception ex)
            {
                throw;
            }
        }
    }
}
