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
        modelBuilder.Entity<Book>().HasData(
            new Book { BookId = 1, Title = "Spider without duty", ISBN = "123GTRED", Price = 10.99m },
            new Book { BookId = 2, Title = "Fortune of Time", ISBN = "12367GPRED", Price = 17.99m }
            );
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
}