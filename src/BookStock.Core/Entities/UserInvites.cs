using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class UserInvites : BaseEntity
{
    public int UserId { get; set; }
    public string Token { get; set; } = null!;
}