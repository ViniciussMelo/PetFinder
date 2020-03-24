using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Interfaces
{
    public interface ICamposPadrao
    {
        int UsuarioCriacao { get; set; }
        DateTime DataCriacao { get; set; }
        int? UsuarioUltimaAlteracao { get; set; }
        DateTime? DataUltimaAlteracao { get; set; }
    }
}
