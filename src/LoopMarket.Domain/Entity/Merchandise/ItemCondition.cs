using System.ComponentModel.DataAnnotations.Schema;

namespace LoopMarket.Domain.Entity.Merchandise;

[Table("ItemCondition", Schema = "Merchandise")]
public class ItemCondition : BaseEntity
{
    public string Label { get; set; }
    public string Description { get; set; }
}