namespace OopLab2.IngredientEntity;

public class Coffee : Ingredient
{
    private string _sort;
    private string _name;

    public string Sort
    {
        get => _sort;
    }

    public string Name
    {
        get => _name;
    }
    
    public Coffee(decimal weight, string sort) : base(weight)
    {
        _sort = sort;
        _name = $"Кофе {_sort}";
    }

    public override string ToString()
    {
        return $"{Weight}г {Name}";
    }
}