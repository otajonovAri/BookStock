using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public string? SystemName { get; set; }
    public string ExternalAuthId { get; set; } = null!;
}