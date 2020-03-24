using PetFinder.Domain.Enums;
using PetFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Entities
{
    public class Pet : ICamposPadrao
    {
        public int PetId { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }

        public int RacaId { get; set; }
        public virtual Raca Raca { get; set; }

        public DateTime DataNascimento { get; set; }
        public Porte Porte { get; set; }
        public Sexo Sexo { get; set; }
        public Castrado Castrado { get; set; }

        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
