using PetFinder.Domain.Interfaces;
using System;

namespace PetFinder.Domain.Entities
{
    public class Endereco:ICamposPadrao
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Rererencia { get; set; }
        public string Cep { get; set; }

        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }

        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
