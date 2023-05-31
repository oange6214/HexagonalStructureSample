using BISP.DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace BISP.InfrastructureLayer;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HexagonalStructureDB;Trusted_Connection=True;Integrated Security = True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .ToTable("Product");
    }
}