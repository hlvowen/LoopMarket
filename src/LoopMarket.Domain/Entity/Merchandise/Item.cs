using System.ComponentModel.DataAnnotations.Schema;

namespace LoopMarket.Domain.Entity.Merchandise;

[Table("Item", Schema = "Merchandise")]
public class Item : BaseEntity
{
    public double SalePrice { get; set; }
    public int ItemConditionId { get; set; }
    public int PackageFormatId { get; set; }
    [ForeignKey("ItemConditionId")]
    public ItemCondition ItemCondition { get; set; }
    [ForeignKey("PackageFormatId")]
    public PackageFormat PackageFormat { get; set; }
}