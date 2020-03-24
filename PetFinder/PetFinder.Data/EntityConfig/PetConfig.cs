using PetFinder.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PetFinder.Data.EntityConfig
{
    public class PetConfig : EntityTypeConfiguration<Pet>
    {
        public PetConfig()
        {
            HasKey(a => a.PetId);
            Property(a => a.Observacao).HasMaxLength(500);
        }
    }
}
