using BookStock.Core.Common;

namespace BookStock.Core.Entities;

public class View : BaseEntity
{
    public int UserId { get; set; }
    public int ViewableId { get; set; }
    public string? ViewableType { get; set; }
    public int Views { get; set; }
}