using System.ComponentModel.DataAnnotations.Schema;
using LoopMarket.Domain.Entity.Merchandise;

namespace LoopMarket.Domain.Entity.SocialMarketplace;

[Table("Offer", Schema = "SocialMarketplace")]
public class Offer : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int ItemId { get; set; }
    [ForeignKey("ItemId")]
    public Item Item { get; set; }
}