using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex04.Models.Configurations
{
    public class PizzaConfiguration : IEntityTypeConfiguration<Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Pizza");

            builder.Property(p => p.IdMassa)
                .HasColumnName("Pizza_Id");

            builder.Property(p => p.IdBordas)
                .HasColumnName("Sabores_Id");


            builder.HasOne(x => x.Borda)
                    .WithMany(p => p.Pizzas)
                    .HasForeignKey(x => x.BordaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizza_Borda");

            builder.HasOne(x => x.Massa)
                    .WithMany(p => p.Pizzas)
                    .HasForeignKey(x => x.MassaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizza_Massa");

            builder.ToTable("Pizza");
        }
    }
}