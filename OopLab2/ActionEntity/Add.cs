using OopLab2.IngredientEntity;

namespace OopLab2.ActionEntity;

public class Add : ActionEntity
{
    private Ingredient _ingredient;
    
    public Add(Ingredient ingredient) : base($"Добавлен {ingredient.ToString()}")
    {
        _ingredient = ingredient;
    }

    public override void Execute(Dictionary<string, object> context)
    {
        if (!context.ContainsKey("curr_ingredients"))
        {
            context.Add("curr_ingredients", new List<ActionEntity>());
        }
        ((List<Ingredient>)context["curr_ingredients"]).Add(_ingredient);
    }

    public override string ToString()
    {
        return $"Добавлен {_ingredient.ToString()}";
    }
}