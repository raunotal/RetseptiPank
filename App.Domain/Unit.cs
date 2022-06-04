using Base.Domain;

namespace App.Domain;

public class Unit : DomainEntityMetaId
{
    public string Name { get; set; } = default!;
    public decimal QuantityInMainUnit { get; set; }

    public Guid? ParentUnitId { get; set; }
    public Unit? ParentUnit { get; set; }

    public ICollection<Unit>? ChildrenUnits { get; set; }
}