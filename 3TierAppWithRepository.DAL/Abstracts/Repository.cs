using _3TierAppWithRepository.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace _3TierAppWithRepository.DAL.Abstracts
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private DbContext _db;
        private IDbSet<T> _dbset;
        public Repository(DbContext context)
        {
            _db = context;
            _dbset = context.Set<T>();
        }

        public T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public void Edit(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate).AsEnumerable();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }
    }
}
