using PetFinder.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PetFinder.Data.EntityConfig
{
    public class AdocaoConfig : EntityTypeConfiguration<Adocao>
    {
        public AdocaoConfig()
        {
            HasRequired(a => a.Doador)
                .WithMany()
                .HasForeignKey(a => a.DoadorId);
        }
    }
}
