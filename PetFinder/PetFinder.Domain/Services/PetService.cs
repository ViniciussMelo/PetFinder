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
    public class PetService : Service<Pet>, IPetService
    {
        private readonly IPetRepository _petRepository;
        private readonly IRacaService _racaService;
        public PetService(IPetRepository repository, IRacaService racaService) : base(repository)
        {
            _petRepository = repository;
        }
    }
}
