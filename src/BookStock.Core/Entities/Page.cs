using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class Page : BaseEntity
{
    public int BookId { get; set; }
    public int ChapterId { get; set; }
    public string Name { get; set; } = null!;
    public string Slug { get; set; } = null!;
    public string Html { get; set; } = null!;
    public string? Text { get; set; } 
}