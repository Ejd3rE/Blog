using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(comment => comment.FullName).HasColumnType("nvarchar(128)");
        builder.Property(comment => comment.Email).HasColumnType("nvarchar(128)");
    }
}