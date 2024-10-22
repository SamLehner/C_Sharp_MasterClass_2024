using Cookie_Cookbook.Recipes.Ingredients;
using Cookie_Cookbook.Recipes;

namespace Cookie_Cookbook.App;

//Having this class inherit the interface for user interaction while overriding the methods defined in the interface
public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{

    private readonly IIngredientsRegister _ingredientsRegister;

    public RecipesConsoleUserInteraction(IIngredientsRegister ingredientRegister)
    {
        _ingredientsRegister = ingredientRegister;
    }

    // Had my exit method on my showmesage method
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        //Forgot to implement the exit method
        Console.WriteLine("Press any key to close");
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
                Console.WriteLine($"*****{counter}*****");
                Console.WriteLine(recipe);
                //Adding a break for readability
                Console.WriteLine();
                ++counter;
            }


        }
    }

    /*Requirements state we should print a message to the console
    then print all the available ingredients preceded by thier Id's */
    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! " +
            "Available ingredients are:");

        //Have no way to call allIngredients in order to iterate through, will have to make a registry for this
        foreach (var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }

    //Implementing user input selection by ID for ingredients
    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {
        bool shallStop = false;
        var ingredients = new List<Ingredient>();

        while (!shallStop)
        {
            Console.WriteLine("Add an ingredient by its ID, " +
                "or type anything else if finished.");

            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int id))
            {
                var selectedIngredient = _ingredientsRegister.GetById(id);
                if (selectedIngredient is not null)
                {
                    ingredients.Add(selectedIngredient);
                }
            }
            else
            {
                shallStop = true;
            }
        }

        return ingredients;
    }
}
