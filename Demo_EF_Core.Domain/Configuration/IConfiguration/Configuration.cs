using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Demo_EF_Core.Domain.Configuration
{
    public abstract class Configuration<T> : IEntityTypeConfiguration<T>
        where T : class
    {
        public abstract void Configure(EntityTypeBuilder<T> builder);
    }
}
