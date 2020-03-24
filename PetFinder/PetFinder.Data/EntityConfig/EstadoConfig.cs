using PetFinder.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PetFinder.Data.EntityConfig
{
    public class EstadoConfig : EntityTypeConfiguration<Estado>
    {
        public EstadoConfig()
        {
            Property(a => a.Uf).HasMaxLength(2);
        }
    }
}
