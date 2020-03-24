using PetFinder.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PetFinder.Data.EntityConfig
{
    public class RacaConfig : EntityTypeConfiguration<Raca>
    {
        public RacaConfig()
        {
            Property(a => a.Descricao).HasMaxLength(500);
        }
    }
}
