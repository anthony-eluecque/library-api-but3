namespace DataAccessLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        public Task<List<T>> GetAll();

        public Task<T> Get(int id);
    }
}
