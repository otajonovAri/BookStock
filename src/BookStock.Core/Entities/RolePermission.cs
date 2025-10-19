using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class RolePermission : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
}