using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.Property(article => article.Title).HasColumnType("nvarchar(128)");
        builder.Property(article => article.Metadata).HasColumnType("nvarchar(256)");
    }
}