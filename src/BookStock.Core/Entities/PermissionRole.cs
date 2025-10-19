using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class PermissionRole : BaseEntity
{
    public int PermissionId { get; set; }
    public int RoleId { get; set; }
}