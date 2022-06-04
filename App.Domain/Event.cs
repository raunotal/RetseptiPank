using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Domain;

namespace App.Domain;

public class Event : DomainEntityMetaId
{

    [MinLength(1)]
    [MaxLength(64)]
    public string Name { get; set; } = default!;
    [MaxLength(1024)]
    public string? Description { get; set; }

    public DateTime EventDateTime { get; set; }

    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}