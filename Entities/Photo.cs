using Blog.Entities.Common;

namespace Blog.Entities;

public class Photo : BaseEntity
{
    public string Src { get; set; } = string.Empty;
    public string? Caption { get; set; }

    // Skaler özelliği
    public Guid ArticleId { get; set; }

    // Gezinti özelliği
    public virtual Article Article { get; set; } = new();
}