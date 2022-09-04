using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Configurations;

public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
{
    public void Configure(EntityTypeBuilder<Photo> builder)
    {
        builder.Property(photo => photo.Src).HasColumnType("nvarchar(128)");
        builder.Property(photo => photo.Caption).HasColumnType("nvarchar(256)");
    }
}