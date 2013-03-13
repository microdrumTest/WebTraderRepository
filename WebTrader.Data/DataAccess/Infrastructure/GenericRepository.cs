﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WebTrader.Data.DataAccess.Infrastructure
{
    public abstract class GenericRepository<C, T> :
        IGenericRepository<T>
        where T : class
        where C : DbContext, new()
    {

        private C _entities = new C();
        protected C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public virtual IEnumerable<T> GetAll()
        {
            IEnumerable<T> query = _entities.Set<T>().ToList();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    _entities.Dispose();

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}