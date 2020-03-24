using PetFinder.Domain.Entities;
using PetFinder.Domain.Interfaces;
using PetFinder.Domain.Interfaces.Repository;
using PetFinder.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Services
{
    public class RacaService : Service<Raca>, IRacaService
    {
        private readonly IRacaRepository _repository;
        public RacaService(IRacaRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
