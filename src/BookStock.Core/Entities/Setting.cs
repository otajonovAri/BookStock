using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class Setting : BaseEntity
{
    public string SettingKey { get; set; } = null!;
    public string? Value { get; set; }
}