using LabSchool.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabSchool.Configuration;

public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.HasKey(e => e.Codigo).HasName("PK__Aluno");

        builder.ToTable("Aluno");

        builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(80);

        builder.Property(p => p.Telefone)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(p => p.DataDeNascimento)
            .IsRequired();

        builder.Property(p => p.Situacao)
            .IsRequired();

        builder.Property(p => p.Nota)
            .IsRequired();

        builder.Property(P => P.CPF)
            .HasMaxLength(11);

        builder.HasIndex(P => P.CPF)
            .IsUnique();

        builder.Property(p => p.QtdAtendimentos)
            .IsRequired();


    }
}