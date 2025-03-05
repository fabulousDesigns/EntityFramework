using EntityFramework.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.DataAccess.FluentApiConfig;

public class FluentBookDetailConfig : IEntityTypeConfiguration<FluentBookDetail>
{
    public void Configure(EntityTypeBuilder<FluentBookDetail> modelBuilder)
    {
        modelBuilder.HasKey(x => x.BookDetailId);
        modelBuilder.Property(x => x.NumberOfChapters).IsRequired();
        modelBuilder.Property(x => x.NumberOfPages).IsRequired();
        modelBuilder.HasOne(x => x.Book).WithOne(x => x.BookDetail).HasForeignKey<FluentBookDetail>(x => x.BookId);
    }
}