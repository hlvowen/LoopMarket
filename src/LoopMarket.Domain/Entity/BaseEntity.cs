using System.ComponentModel.DataAnnotations;

namespace LoopMarket.Domain.Entity;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
}