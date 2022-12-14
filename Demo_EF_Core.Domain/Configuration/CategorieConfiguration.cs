using Demo_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Demo_EF_Core.Domain.Configuration
{
    public class CategorieConfiguration : Configuration<Categorie>
    {
        public override void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable("Categorie");

            builder.Property(c => c.NomCategorie)
                .HasMaxLength(75)
                .IsRequired();            

            builder.HasOne<Utilisateur>()
                .WithMany(u => u.Categories)
                .HasForeignKey(c => c.UtilisateurId);

            builder.HasMany(c => c.Contacts)
                .WithMany(co => co.Categories)
                .UsingEntity("ContactCategorie");
        }
    }
}
