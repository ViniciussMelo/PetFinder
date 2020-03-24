using PetFinder.Data.Interfaces;
using PetFinder.Domain.Entities;
using PetFinder.Domain.Interfaces;
using PetFinder.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.Repository
{
    public class RacaRepository : Repository<Raca>, IRacaRepository
    {
        public RacaRepository(IDbContext dbContext) : base(dbContext)
        {
        }

        public override Raca Get(int id)
        {
            return _dbSet.FirstOrDefault(a => a.RacaId == id);
        }

        public override void Delete(int id)
        {
            var raca = _dbSet.FirstOrDefault(a => a.RacaId == id);
            _dbSet.Remove(raca);
        }
    }
}
