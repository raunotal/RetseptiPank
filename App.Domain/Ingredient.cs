using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class Ingredient : DomainEntityMetaId
{
    [MinLength(1)]
    [MaxLength(64)]
    public string Name { get; set; } = default!;
    
    [MaxLength(128)]
    public string? Description { get; set; }

    public Guid UnitId { get; set; }
    public Unit? Unit { get; set; }
}