namespace OopLab2.IngredientEntity;

public class Milk : Ingredient
{
    private decimal _fatContent;
    private string _name;

    public decimal FatContent
    {
        get => _fatContent;
    }

    public string Name
    {
        get => _name;
    }
    
    public Milk(decimal weight, decimal fatContent) : base(weight)
    {
        _fatContent = fatContent;
        _name = $"Молоко {_fatContent}";
    }

    public override string ToString()
    {
        return $"{Weight}г {Name}";
    }
}