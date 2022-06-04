using Base.Domain;

namespace App.Domain;

public class RecipeIngredient : DomainEntityMetaId
{
    public decimal Quantity { get; set; }

    public Guid RecipeId { get; set; }
    public Recipe? Recipe { get; set; }

    public Guid IngredientId { get; set; }
    public Ingredient? Ingredient { get; set; }
}