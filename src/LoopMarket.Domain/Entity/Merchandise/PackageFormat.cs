using System.ComponentModel.DataAnnotations.Schema;

namespace LoopMarket.Domain.Entity.Merchandise;

[Table("PackageFormat", Schema = "Merchandise")]
public class PackageFormat : BaseEntity
{
    public string Label { get; set; }
    public string Description { get; set; }
}