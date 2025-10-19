using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class Tag : BaseEntity
{
    public int EntityId { get; set; }
    public string? EntityType { get; set; }
    public string? Name { get; set; }
    public string? Value { get; set; }
    public int Order { get; set; }
}