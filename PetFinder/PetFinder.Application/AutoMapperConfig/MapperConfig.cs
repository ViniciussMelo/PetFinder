using AutoMapper;
using PetFinder.Application.ViewModel.Raca;
using PetFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Application.AutoMapperConfig
{
    public static class MapperConfig
    {
        public static IMapper Mapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // cfg.AddProfile<AppProfile>();
                cfg.CreateMap<Raca, RacaViewModel>().ReverseMap();
            });

           // var mapper = config.CreateMapper();
            // or
            IMapper map = new Mapper(config);
            //var dest = mapper.Map<Source, Dest>(new Source());

            return map;

            // vscheffer@narwalsistemas.com.br
        }
    }
}
