using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.DataAccess;


public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=BooksDb;TrustServerCertificate=True;Trusted_Connection=True;");
    }

    public DbSet<Book> Books { get; set; }
}