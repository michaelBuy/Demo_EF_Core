using Demo_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Demo_EF_Core.Domain.Configuration
{
    public class CategorieConfiguration : Configuration<Categorie>
    {
        public override void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable("Configuration");

            builder.Property(c => c.NomCategorie)
                .HasMaxLength(75)
                .IsRequired();

            builder.Property(c => c.UtilisateurId)
                .IsRequired();
        }
    }
}
