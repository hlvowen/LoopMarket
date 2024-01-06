using System.ComponentModel.DataAnnotations.Schema;

namespace LoopMarket.Domain.Entity.Catalog;

[Table("ItemSubCategory", Schema = "Catalog")]
public class ItemSubCategory : BaseEntity
{
    public string Name { get; set; }
    public int ItemCategoryId { get; set; }
    [ForeignKey("ItemCategoryId")]
    public ItemCategory ItemCategory { get; set; }
}