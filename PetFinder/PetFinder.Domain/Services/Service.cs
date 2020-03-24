using PetFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity obj)
        {
            _repository.Add(obj);
            return obj;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public List<TEntity> ListAll()
        {
            return _repository.ListAll();
        }

        public TEntity Update(TEntity obj)
        {
            _repository.Update(obj);
            return obj;
        }
    }
}
