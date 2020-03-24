using PetFinder.Application.ViewModel.Raca;
using PetFinder.Domain.Entities;
using PetFinder.Domain.Interfaces.Services;
using PetFinder.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetFinder.Data.Interfaces;

namespace PetFinder.Application.ApplicationService
{
    public class RacaAppService : AppService
    {
        private readonly IRacaService _racaService;

        public RacaAppService(IRacaService service, IUnitOfWork uow) : base(uow)
        {
            _racaService = service;
        }

        public void Dispose()
        {
           // throw new NotImplementedException();
        }


        public List<RacaViewModel> ListAll()
        {
            var racas = _racaService.ListAll();

            var mapper = AutoMapperConfig.MapperConfig.Mapper();

            return mapper.Map<List<Raca>, List<RacaViewModel>>(racas);
        }

        public RacaViewModel Get(int id)
        {
            var raca = _racaService.Get(id);
            var mapper = AutoMapperConfig.MapperConfig.Mapper();


            return mapper.Map<Raca, RacaViewModel>(raca);
        }

        public void Add(Raca raca)
        {
            BeginTransaction();
            _racaService.Add(raca);
            Commit();
        }

        public void Update(RacaViewModel raca)
        {
            BeginTransaction();
            var racaOriginal = _racaService.Get(raca.RacaId);
            var mapper = AutoMapperConfig.MapperConfig.Mapper();
            var racaUpdate = mapper.Map(raca, racaOriginal);

            _racaService.Update(racaUpdate);
            Commit();
        }

        public void Delete(int id)
        {
            BeginTransaction();
            _racaService.Delete(id);
            Commit();
        }
    }
}
