using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class SocialAccount : BaseEntity
{
    public int UserId { get; set; }
    public string? Driver { get; set; }
    public int DriverId { get; set; }
    public string? Avatar { get; set; }
}