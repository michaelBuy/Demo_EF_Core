using Demo_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Demo_EF_Core.Domain.Configuration
{
    public class UtilisateurConfiguration : Configuration<Utilisateur>
    {       
        public override void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.ToTable("Utilisateur");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(384);

            builder.Property(u => u.Nom)
                .IsRequired()
                .HasMaxLength(75);

            builder.Property(u => u.Prenom)
                .IsRequired()
                .HasMaxLength(75);

            builder.Property(u => u.Passwd)
                .IsRequired();
        }
    }
}
