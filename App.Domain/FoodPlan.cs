using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Domain;

namespace App.Domain;

public class FoodPlan : DomainEntityMetaId
{

    [MinLength(1)]
    [MaxLength(64)]
    public string Name { get; set; } = default!;
    [MaxLength(512)]
    public string? Description { get; set; }

    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}