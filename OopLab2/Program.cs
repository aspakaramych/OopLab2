using OopLab2;
using OopLab2.Action;
using OopLab2.Ingredient;

class Program
{
    static void Main(string[] args)
    {
        var repo = new DrinkRepo();
        var service = new DrinkService(repo);
        var controller = new DrinkController(service);
        controller.Run();
    }
}