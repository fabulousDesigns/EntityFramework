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
        modelBuilder.Entity<FluentAuthor>().HasKey(x => x.AuthorId);
        modelBuilder.Entity<FluentAuthor>().Property(x => x.FirstName).IsRequired();
        modelBuilder.Entity<FluentAuthor>().Property(x => x.FirstName).HasMaxLength(50);
        modelBuilder.Entity<FluentAuthor>().Property(x => x.LastName).IsRequired();
        modelBuilder.Entity<FluentAuthor>().Property(x => x.Location).HasMaxLength(50);
        modelBuilder.Entity<FluentAuthor>().Ignore(x => x.FullName);
        // Fluent Book Entity
        modelBuilder.Entity<FluentBook>().HasKey(x => x.BookId);
        modelBuilder.Entity<FluentBook>().Property(x => x.Title).IsRequired();
        modelBuilder.Entity<FluentBook>().Property(x => x.Title).HasMaxLength(50);
        modelBuilder.Entity<FluentBook>().Property(x => x.ISBN).HasMaxLength(13);
        modelBuilder.Entity<FluentBook>().HasOne(x => x.Publisher).WithMany(x => x.Books).HasForeignKey(x => x.PublisherId);
        // Fluent Book Detail Entity
        modelBuilder.Entity<FluentBookDetail>().HasKey(x => x.BookDetailId);
        modelBuilder.Entity<FluentBookDetail>().Property(x => x.NumberOfChapters).IsRequired();
        modelBuilder.Entity<FluentBookDetail>().Property(x => x.NumberOfPages).IsRequired();
        modelBuilder.Entity<FluentBookDetail>().HasOne(x => x.Book).WithOne(x => x.BookDetail).HasForeignKey<FluentBookDetail>(x => x.BookId);
        // Fluent Publisher Entity
        modelBuilder.Entity<FluentPublisher>().HasKey(x => x.PublisherId);
        modelBuilder.Entity<FluentPublisher>().Property(x => x.Name).IsRequired();
        modelBuilder.Entity<FluentPublisher>().Property(x => x.Name).HasMaxLength(50);
        modelBuilder.Entity<FluentPublisher>().Property(x => x.Location).HasMaxLength(50);
        
        
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