using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class SearchTerm : BaseEntity
{
    public string? Term { get; set; }
    public string? EntityType { get; set; }
    public int EntityId { get; set; }
    public int Score { get; set; }
}