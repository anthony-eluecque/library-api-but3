﻿namespace DataAccessLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        public Task<List<T>> GetAll();

        public Task<T> Get(int id);

        public Task Update(T entity);

        public Task Delete(T entity);

        public Task Add(T entity);
    }
}
