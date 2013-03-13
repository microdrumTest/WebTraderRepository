using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WebTrader.Data.DataAccess.Infrastructure
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
