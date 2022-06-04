using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Domain;

namespace App.Domain;

public class Recipe : DomainEntityMetaId
{
    [MinLength(1)]
    [MaxLength(64)]
    public string Name { get; set; } = default!;
    [MaxLength(256)]
    public string? Description { get; set; }
    [MaxLength(2048)]
    public string? Directions { get; set; }
    public bool IsPublic { get; set; }

    public Guid? FoodPlanId { get; set; }
    public FoodPlan? FoodPlan { get; set; }

    public Guid? EventId { get; set; }
    public Event? Event { get; set; }

    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}