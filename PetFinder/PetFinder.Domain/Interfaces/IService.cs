using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Get(int id);
        List<TEntity> ListAll();
        void Delete(int id);
    }
}
