using EntityFramework.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.DataAccess.FluentApiConfig;

public class FluentBookConfig : IEntityTypeConfiguration<FluentBook>
{
    public void Configure(EntityTypeBuilder<FluentBook> modelBuilder)
    {
        modelBuilder.HasKey(x => x.BookId);
        modelBuilder.Property(x => x.Title).IsRequired();
        modelBuilder.Property(x => x.Title).HasMaxLength(50);
        modelBuilder.Property(x => x.ISBN).HasMaxLength(13);
        modelBuilder.HasOne(x => x.Publisher).WithMany(x => x.Books).HasForeignKey(x => x.PublisherId);
    }
}