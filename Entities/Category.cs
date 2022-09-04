using Blog.Entities.Common;

namespace Blog.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Metadata { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public byte Spacing { get; set; }

    // Skaler özelliği
    public Guid? ParentId { get; set; }

    // Gezinti özelliği
    public virtual Category? Parent { get; set; }
    public virtual ICollection<Article>? Articles { get; set; }
}