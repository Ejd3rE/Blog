using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(category => category.Name).HasColumnType("nvarchar(64)");
        builder.Property(category => category.Metadata).HasColumnType("nvarchar(256)");
        builder.Property(category => category.Photo).HasColumnType("nvarchar(128)");
    }
}