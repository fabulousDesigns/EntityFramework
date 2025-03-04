using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.DataAccess;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=EF;TrustServerCertificate=True;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().Property(x => x.Price).HasPrecision(18, 5);
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }
}