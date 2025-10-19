using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class Session : BaseEntity
{
    public int UserId { get; set; }
    public string? IpAddress { get; set; }
    public string? UserAgent { get; set; }
    public string? Payload { get; set; }
    public int LastActivity { get; set; }
}