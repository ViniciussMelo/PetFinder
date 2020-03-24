using PetFinder.Data.Interfaces;
using PetFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>,
        IDisposable where TEntity : class
    {
        private readonly IDbContext _dbContext;
        public readonly IDbSet<TEntity> _dbSet;

        public Repository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public TEntity Add(TEntity obj)
        {
            _dbSet.Add(obj);
            return obj;
        }

        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //   throw new NotImplementedException();
        }

        public virtual TEntity Get(int id)
        {
            throw new NotImplementedException();
            // return _dbSet.FirstOrDefault(a=>a.)
        }

        public List<TEntity> ListAll()
        {
            return _dbSet.ToList();
        }

        public TEntity Update(TEntity obj)
        {
            //_dbSet.Attach(obj);
            return obj;
        }
    }
}
