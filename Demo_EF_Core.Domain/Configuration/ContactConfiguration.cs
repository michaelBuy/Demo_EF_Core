using Demo_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Demo_EF_Core.Domain.Configuration
{
    public class ContactConfiguration : Configuration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");           
                

            builder.Property(c => c.EmailContact)
                .IsRequired()
                .HasMaxLength(384);

            builder.Property(c => c.NomContact)
                .IsRequired();

            builder.Property(c => c.PrenomContact)
                .IsRequired();

            builder.Property(c => c.Anniversaire)
                .IsRequired();

            builder.Property(c => c.Tel)
                .IsRequired();

            builder.Property(c => c.IdUtilisateur)
                .IsRequired();
        }
    }
}
