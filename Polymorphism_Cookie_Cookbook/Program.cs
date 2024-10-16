
//Starting with the main data for the program, will work on implementation with clean code following this

using Cookie_Cookbook.Recipes;
using Cookie_Cookbook.Recipes.Ingredients;
using System.Runtime.CompilerServices;

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipesConsoleUserInteraction());
cookiesRecipesApp.Run("recipes.txt");


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
    public void Run(string filePath)
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        //_recipesUserInteraction.PromptToCreateRecipe();

        //var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        //if(ingredients.Count > 0)
        //{
        //    var recipes = new Recipe(ingredients);
        //    allRecipes.Add(recipe);
        //    _recipesRepository.Write(filePath, allRecipes);

        //    _recipesUserInteraction.ShowMessage("Recipe added:");
        //    _recipesUserInteraction.ShowMessage(recipe.ToString());
        //}
        //else
        //{
        //    _recipesUserInteraction.ShowMessage(
        //        "No ingredients have been selected. " +
        //        "Recipe will not be saved.");
        //}

        _recipesUserInteraction.Exit();
    }
}

//Creating an interface instead of a class for user interaction so we dont break the Dependecy Inversion Principle
public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();

    // Needs to pring existiing recupes separting with asterisks and number of recipe, if there are none nothing should happen
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
}

//Having this class inherit the interface for user interaction while overriding the methods defined in the interface
public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void Exit()
    {
        //Forgot to implement the exit method
        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);

            /*Tried using a for loop with the recipe index +1 but it doesnt work on IEnumerable types
             * Switched it to a for each loop with a counter so that we can still use the IEnumerable type */

            var counter = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"******{counter}*****");
                Console.WriteLine(recipe);
                //Adding a break for readability
                Console.WriteLine();
                ++counter;
            }


        }
    }
}

public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
}

public class RecipesRepository : IRecipesRepository
{
    public List<Recipe> Read(string filePath)
    {
        //instantiating for testing
        return new List<Recipe>
        { 
            new Recipe(new List<Ingredient>
            {
                new WheatFlour(),
                new Butter(),
                new Sugar()
            }),
            new Recipe(new List<Ingredient>
            {
                new CocoaPowder(),
                new SpeltFlour(),
                new Cinnamon(),
            })
        };

    }
}