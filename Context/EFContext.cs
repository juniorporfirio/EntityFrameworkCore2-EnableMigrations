
using Microsoft.EntityFrameworkCore;

public class EFContext : DbContext
{
    public DbSet<Estado> Estado { get; set; }
    public DbSet<Cidade> Cidade { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        base.OnModelCreating(modelBuilder);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connection = @"Server=localhost;Database=EFCore;Integrated Security=True;";
        optionsBuilder.UseSqlServer(connection);
    }



}