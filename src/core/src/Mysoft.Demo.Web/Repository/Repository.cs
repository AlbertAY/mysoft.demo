using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mysoft.Demo.Web
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext dbContext = null;
        DbSet<T> _objectSet;

        public Repository(DbContext _dbContext)
        {
            dbContext = _dbContext;
            _objectSet = dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return _objectSet.Where(predicate);
            }
            return _objectSet.AsEnumerable();
        }
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.First(predicate);
        }
        public void Add(T entity)
        {
            _objectSet.Add(entity);
        }

        public void Update(T entity)
        {
            _objectSet.Attach(entity);
        }

        public void Delete(T entity)
        {
            _objectSet.Remove(entity);
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate != null)
            {
                return _objectSet.Where(predicate);
            }
            return _objectSet.AsEnumerable();
        }

        public T Get(Func<T, bool> predicate)
        {
            return _objectSet.First(predicate);
        }
    }
}
