
//Starting with the main data for the program, will work on implementation with clean code following this

using System.Runtime.CompilerServices;

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipesConsoleUserInteraction());
cookiesRecipesApp.Run();


/* Implementing the class we need from the main body of code from our program.
This will hold all the main data for the main application workflow for our task */
public class CookiesRecipesApp 
{

    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction; 
    }
    public void Run()
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if(ingredients.Count > 0)
        {
            var recipes = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();
    }
}

//Creating an interface instead of a class for user interaction so we dont break the Dependecy Inversion Principle
public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
}

//Having this class inherit the interface for user interaction while overriding the methods defined in the interface
public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void Exit()
    {
        throw new NotImplementedException();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
}

public interface IRecipesRepository
{

}

public class RecipesRepository : IRecipesRepository 
{
}