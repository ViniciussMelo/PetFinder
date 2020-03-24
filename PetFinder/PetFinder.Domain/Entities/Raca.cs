using PetFinder.Domain.Enums;
using PetFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Entities
{
    public class Raca: ICamposPadrao
    {
        public int RacaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public TipoPet Tipo { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
