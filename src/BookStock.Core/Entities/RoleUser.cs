using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class RoleUser : BaseEntity
{
    public int UserId { get; set; }
    public int RoleId { get; set; }
}