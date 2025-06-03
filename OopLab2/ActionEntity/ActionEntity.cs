namespace OopLab2.ActionEntity;

public abstract class ActionEntity : IElement
{
    private string _description;

    public string Description
    {
        get => _description;
    }
    
    public ActionEntity(string description)
    {
        _description = description;
    }
    
    public abstract void Execute(Dictionary<string, object> context);
}