using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(author => author.Name).HasColumnType("nvarchar(64)");
        builder.Property(author => author.Surname).HasColumnType("nvarchar(64)");
        builder.Property(author => author.City).HasColumnType("nvarchar(64)");
        builder.Property(author => author.Town).HasColumnType("nvarchar(64)");
        builder.Property(author => author.Email).HasColumnType("nvarchar(128)");
        builder.Property(author => author.Password).HasColumnType("nvarchar(256)");
    }
}