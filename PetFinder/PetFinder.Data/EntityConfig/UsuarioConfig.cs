using PetFinder.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PetFinder.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            Property(a => a.Cpf).HasMaxLength(11);
            Property(a => a.Telefone).HasMaxLength(20);
        }
    }
}
