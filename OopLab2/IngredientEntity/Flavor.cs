namespace OopLab2.IngredientEntity;

public class Flavor : Ingredient
{
    private string _type;
    private string _name;

    public string Type
    {
        get => _type;
    }

    public string Name
    {
        get => _name;
    }
    
    public Flavor(decimal weight, string type) : base(weight)
    {
        _type = type;
        _name = $"Сироп {_type}";
    }

    public override string ToString()
    {
        return $"{Weight}г {Name}";
    }
}