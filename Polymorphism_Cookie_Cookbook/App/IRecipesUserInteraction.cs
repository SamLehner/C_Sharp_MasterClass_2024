using Cookie_Cookbook.Recipes.Ingredients;
using Cookie_Cookbook.Recipes;

namespace Cookie_Cookbook.App;

//Creating an interface instead of a class for user interaction so we dont break the Dependecy Inversion Principle
public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();

    // Needs to pring existiing recupes separting with asterisks and number of recipe, if there are none nothing should happen
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
