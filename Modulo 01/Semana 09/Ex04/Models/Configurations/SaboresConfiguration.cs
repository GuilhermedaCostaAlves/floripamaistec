using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex04.Models.Configurations
{
    public class SaboresConfiguration : IEntityTypeConfiguration<Sabores>
    {
        public void Configure(EntityTypeBuilder<Sabores> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Sabores");


            builder.ToTable("Sabores");
        }
    }
}