using PetFinder.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Entities
{
    public class PetImagem
    {
        public int PetImagemId { get; set; }

        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

        public string Nome { get; set; }

        public byte[] Arquivo { get; set; }

        public FormatoArquivoImagem Formato { get; set; }
        public bool Capa { get; set; }


    }
}
