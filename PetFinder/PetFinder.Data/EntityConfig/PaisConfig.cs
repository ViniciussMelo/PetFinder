using PetFinder.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PetFinder.Data.EntityConfig
{
    public class PaisConfig : EntityTypeConfiguration<Pais>
    {
        public PaisConfig()
        {
            Property(a => a.Sigla).HasMaxLength(2);
        }
    }
}
