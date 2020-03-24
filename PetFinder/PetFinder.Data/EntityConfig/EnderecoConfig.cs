using PetFinder.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PetFinder.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            Property(a => a.Numero).HasMaxLength(10);
            Property(a => a.Cep).HasMaxLength(8);
        }
    }
}
