using LabSchool.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabSchool.Configuration;

public class PedagogoConfiguration : IEntityTypeConfiguration<Pedagogo>
{
    public void Configure(EntityTypeBuilder<Pedagogo> builder)
    {
        builder.HasKey(e => e.Codigo).HasName("PK__Pedagogo");

        builder.ToTable("Pedagogo");

        builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(80);

        builder.Property(p => p.Telefone)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(p => p.DataDeNascimento)
            .IsRequired();

        builder.Property(p => p.QtdAtendimentos)
            .IsRequired();

        builder.Property(P => P.CPF)
            .HasMaxLength(11);

        builder.HasIndex(P => P.CPF)
            .IsUnique();


    }
}