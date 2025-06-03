namespace OopLab2.IngredientEntity;

public class Ice : Ingredient
{
    private string _name;

    public string Name
    {
        get => _name;
    }
    
    public Ice(decimal weight) : base(weight)
    {
        _name = "лед";
    }

    public override string ToString()
    {
        return $"{Weight}г {Name}";
    }
}