using PetFinder.Application.ApplicationService;
using PetFinder.Application.ViewModel.Raca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetFinder.Web.Controllers
{
    public class RacaController : Controller
    {
        private readonly RacaAppService _appService;

        public RacaController(RacaAppService appService)
        {
            _appService = appService;
        }

        // GET: Raca
        public ActionResult Index()
        {
            var lista = new List<RacaViewModel>();

            lista.Add(new RacaViewModel()
            {
                RacaId=1,
                Nome = "PitBull",
                Descricao = "Feroz",
                Tipo = Domain.Enums.TipoPet.Cachorro
            });

            return View(lista);
        }


        public ActionResult Create()
        {
            return View(new RacaViewModel());
        }

    }
}