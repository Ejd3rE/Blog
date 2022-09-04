using System.Reflection;
using Blog.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Contexts;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {
        
    }

    DbSet<Article> Articles => Set<Article>();
    DbSet<Author> Authors => Set<Author>();
    DbSet<Category> Categories => Set<Category>();
    DbSet<Comment> Comments => Set<Comment>();
    DbSet<Photo> Photos => Set<Photo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}