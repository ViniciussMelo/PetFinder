using PetFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Entities
{
    public class AdocaoInteresse:ICamposPadrao
    {
        public int AdocaoInteresseId { get; set; }
        public int AdocaoId { get; set; }
        public virtual Adocao Adocao { get; set; }

        public string Mensagem { get; set; }
        public int InteressadoId { get; set; }
        public virtual Usuario Interessado { get; set; }

        public bool Aprovado { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
