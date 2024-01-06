using System.ComponentModel.DataAnnotations.Schema;

namespace LoopMarket.Domain.Entity.Catalog;

[Table("ItemCategory", Schema = "Catalog")]
public class ItemCategory : BaseEntity
{
    public string Name { get; set; }
}