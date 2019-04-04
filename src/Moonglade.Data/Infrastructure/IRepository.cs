﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Moonglade.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        T Get(object key);

        T Get(Expression<Func<T, bool>> condition);

        IReadOnlyList<T> Get(bool asNoTracking = true);

        IReadOnlyList<T> Get(ISpecification<T> spec, bool asNoTracking = true);

        IReadOnlyList<TResult> Select<TResult>(Expression<Func<T, TResult>> selector, bool asNoTracking = true);

        T Add(T entity);

        int Update(T entity);

        int Delete(T entity);

        int Delete(object key);

        int Delete(IEnumerable<T> entities);

        int Count(ISpecification<T> spec);

        bool Any(Expression<Func<T, bool>> condition);

        Task<T> GetAsync(object key);

        Task<T> GetAsync(Expression<Func<T, bool>> condition);

        Task<IReadOnlyList<T>> GetAsync(bool asNoTracking = true);

        Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec, bool asNoTracking = true);

        Task<IReadOnlyList<TResult>> SelectAsync<TResult>(Expression<Func<T, TResult>> selector, bool asNoTracking = true);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task DeleteAsync(IEnumerable<T> entities);

        Task DeleteAsync(object key);

        Task<int> CountAsync(ISpecification<T> spec);
    }
}
