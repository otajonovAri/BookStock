using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class PasswordResets : BaseEntity
{
    public string Email { get; set; } = null!;
    public string Token { get; set; } = null!;
    public DateTime CreateAt { get; set; }
}