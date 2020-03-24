using PetFinder.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PetFinder.Data.EntityConfig
{
    public class AdocaoInteresseConfig : EntityTypeConfiguration<AdocaoInteresse>
    {
        public AdocaoInteresseConfig()
        {
            HasRequired(a => a.Interessado)
                .WithMany()
                .HasForeignKey(a => a.InteressadoId);
        }
    }
}
