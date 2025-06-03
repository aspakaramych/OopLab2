namespace OopLab2.IngredientEntity;

public abstract class Ingredient : IElement
{
    private decimal _weight;

    public decimal Weight
    {
        get => _weight;
        set => _weight = value < 0 ? 0 : value;
    }

    public Ingredient(decimal weight)
    {
        _weight = weight;
    }
}