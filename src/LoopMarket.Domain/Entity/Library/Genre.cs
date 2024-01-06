using System.ComponentModel.DataAnnotations.Schema;

namespace LoopMarket.Domain.Entity.Library;

[Table("Genre", Schema = "Library")]
public class Genre : BaseEntity
{
    public string Name { get; set; }
    public int LitteraryGenreId { get; set; }
    [ForeignKey("LitteraryGenreId")]
    public LitteraryGenre LitteraryGenre { get; set; }
}