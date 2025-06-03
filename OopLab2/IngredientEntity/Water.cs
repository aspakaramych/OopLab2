namespace OopLab2.IngredientEntity;

public class Water : Ingredient
{
    private string _name;

    public string Name
    {
        get => _name;
    }
    
    public Water(decimal weight) : base(weight)
    {
        _name = "вода";
    }

    public override string ToString()
    {
        return $"{Weight}г {Name}";
    }
}