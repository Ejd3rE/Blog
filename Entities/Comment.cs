using Blog.Entities.Common;

namespace Blog.Entities;

public class Comment : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }

    // Skaler özelliği
    public Guid? AuthorId { get; set; }
    public Guid ArticleId { get; set; }

    // Gezinti özelliği
    public virtual Author? Author { get; set; }
    public virtual Article Article { get; set; } = new();
}