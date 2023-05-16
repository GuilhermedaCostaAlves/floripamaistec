using Microsoft.EntityFrameworkCore;
using LabSchool.Models;
using LabSchool.Configuration;

namespace LabSchool.Context;

public class LabSchoolContext : DbContext
{ 
    public LabSchoolContext(DbContextOptions<LabSchoolContext> options) : base(options)
    {

    }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Pedagogo> Pedagogos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    
    {
        modelBuilder.ApplyConfiguration(new AlunoConfiguration());
        modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
        modelBuilder.ApplyConfiguration(new PedagogoConfiguration());

    }
}