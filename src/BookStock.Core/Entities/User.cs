using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class User : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string RememberToken { get; set; } = null!;
    public int EmailConfirmed { get; set; }
    public int ImgId { get; set; }
    public int ExternalAuthId { get; set; }
    public string? SystemName { get; set; }
}