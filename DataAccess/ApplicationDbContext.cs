using EntityFramework.DataAccess.FluentApiConfig;
using EntityFramework.Models;
using EntityFramework.Models.FluentModels;
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
        // Fluent Author Entity
        modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
        // Fluent Book Entity
        modelBuilder.ApplyConfiguration(new FluentBookConfig());
        // Fluent Book Detail Entity
        modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());
        // Fluent Publisher Entity
        modelBuilder.ApplyConfiguration(new FluentPublisherConfig());
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<BookDetail> BookDetails { get; set; }
    public DbSet<FluentAuthor> FluentAuthors { get; set; }
    public DbSet<FluentBook> FluentBooks { get; set; }
    public DbSet<FluentBookDetail> FluentBookDetails { get; set; }
    public DbSet<FluentPublisher> FluentPublishers { get; set; }
}