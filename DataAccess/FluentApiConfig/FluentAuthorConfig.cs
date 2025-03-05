using EntityFramework.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.DataAccess.FluentApiConfig;

public class FluentAuthorConfig : IEntityTypeConfiguration<FluentAuthor>
{
    public void Configure(EntityTypeBuilder<FluentAuthor> modelBuilder)
    {
        modelBuilder.HasKey(x => x.AuthorId);
        modelBuilder.Property(x => x.FirstName).IsRequired();
        modelBuilder.Property(x => x.FirstName).HasMaxLength(50);
        modelBuilder.Property(x => x.LastName).IsRequired();
        modelBuilder.Property(x => x.Location).HasMaxLength(50);
        modelBuilder.Ignore(x => x.FullName);
    }
}