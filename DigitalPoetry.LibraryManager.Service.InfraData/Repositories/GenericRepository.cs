﻿namespace DigitalPoetry.LibraryManager.Service.Infra.Data.Repositories
{
    using DigitalPoetry.LibraryManager.Service.Infra.Data.Interfaces.Repositories;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>Generic Repository</summary>
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        private readonly IDisposeDatabase _disposeDatabase;

        public GenericRepository(IDisposeDatabase disposeDatabase)
        {
            _disposeDatabase = disposeDatabase;
        }

        public void Dispose()
        {
            _disposeDatabase.DisposedData(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }  
    }
}
