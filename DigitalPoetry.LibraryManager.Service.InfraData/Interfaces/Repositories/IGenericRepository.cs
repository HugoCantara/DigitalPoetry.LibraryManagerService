﻿namespace DigitalPoetry.LibraryManager.Service.Infra.Data.Interfaces.Repositories
{
    using System.Linq.Expressions;

    /// <summary>Generic Repository Interface</summary>
    public interface IGenericRepository<T> : IDisposable
    {
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");

        T GetById(object id);

        Task<T> GetByIdAsync(object id);

        void Add(T entity);

        Task<T> AddAsync(T entity);

        void Update(T entity);

        Task<T> UpdateAsync(T entity);

        void Delete(T entity);

        Task<T> DeleteAsync(T entity);
    }
}