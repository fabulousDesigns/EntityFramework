using EntityFramework.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.DataAccess.FluentApiConfig;

public class FluentPublisherConfig : IEntityTypeConfiguration<FluentPublisher>
{
    public void Configure(EntityTypeBuilder<FluentPublisher> modelBuilder)
    {
        modelBuilder.HasKey(x => x.PublisherId);
        modelBuilder.Property(x => x.Name).IsRequired();
        modelBuilder.Property(x => x.Name).HasMaxLength(50);
        modelBuilder.Property(x => x.Location).HasMaxLength(50);
    }
}