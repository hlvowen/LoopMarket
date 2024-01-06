using System.ComponentModel.DataAnnotations.Schema;
using LoopMarket.Domain.Entity.Catalog;
using LoopMarket.Domain.Entity.Merchandise;

namespace LoopMarket.Domain.Entity.Library;

[Table("Book", Schema = "Library")]
public class Book : BaseEntity
{
    public string Isbn { get; set; }
    public int ItemId { get; set; }
    public int GenreId { get; set; }
    [ForeignKey("ItemId")]
    public Item Item { get; set; }
    [ForeignKey("GenreId")]
    public Genre Genre { get; set; }
}