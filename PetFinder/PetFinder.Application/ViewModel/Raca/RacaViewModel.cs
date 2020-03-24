using PetFinder.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Application.ViewModel.Raca
{
    public class RacaViewModel
    {
        public int RacaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoPet Tipo { get; set; }
    }
}
