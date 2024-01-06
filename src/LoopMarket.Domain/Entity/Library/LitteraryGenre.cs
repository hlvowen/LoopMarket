using System.ComponentModel.DataAnnotations.Schema;
using LoopMarket.Domain.Entity.Catalog;
using LoopMarket.Domain.Entity.Library;

namespace LoopMarket.Domain.Entity.Library;

[Table("LitteraryGenre", Schema = "Library")]
public class LitteraryGenre : BaseEntity
{
    public string Name { get; set; }
    public int ItemSubCategoryId { get; set; }
    [ForeignKey("ItemSubCategoryId")]
    public ItemSubCategory ItemSubCategory { get; set; }
}