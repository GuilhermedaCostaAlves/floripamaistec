using LabSchool.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabSchool.Configuration;

public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        builder.HasKey(e => e.Codigo).HasName("PK__Professor");

        builder.ToTable("Professor");

        builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(80);

        builder.Property(p => p.Telefone)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(p => p.DataDeNascimento)
            .IsRequired();

        builder.Property(p => p.Estado)
            .IsRequired();

        builder.Property(p => p.Experiencia)
            .IsRequired();

        builder.Property(P => P.CPF)
            .HasMaxLength(11);

        builder.HasIndex(P => P.CPF)
            .IsUnique();

        builder.Property(p => p.Formacao)
            .IsRequired();


    }
}