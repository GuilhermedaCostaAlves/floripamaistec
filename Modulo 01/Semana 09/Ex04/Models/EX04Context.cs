using Microsoft.EntityFrameworkCore;

namespace Ex04.Models;

public partial class Pizzaria09Context : DbContext
{
    public Pizzaria09Context()
    {
    }

    public Pizzaria09Context(DbContextOptions<Pizzaria09Context> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-43ORG2R\\SQLEXPRESS\\SQLEXPRESS;Database=PIZZARIA09;User ID=sa;Password=8800;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}