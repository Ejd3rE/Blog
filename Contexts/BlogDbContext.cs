using Microsoft.EntityFrameworkCore;

namespace Blog.Contexts;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {
        
    }
}