using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex04.Models.Configurations
{
    public class MassaConfiguration : IEntityTypeConfiguration<Massa>
    {
        public void Configure(EntityTypeBuilder<Massa> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Massa");


            builder.ToTable("Massa");
        }
    }
}