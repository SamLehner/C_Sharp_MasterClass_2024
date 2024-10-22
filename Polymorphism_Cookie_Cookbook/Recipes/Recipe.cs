using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookie_Cookbook.Recipes.Ingredients;

namespace Cookie_Cookbook.Recipes;


//Simply a wrapper for a collection of ingredients
public class Recipe
{
    /*Changing it from list as having a public list is risky since anyone who uses
     * the list object has access to any method such as .Clear which we do not want.
     * We can use the IEnumerable to acheive desired result. */
    public IEnumerable<Ingredient> Ingredients { get; }

    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }


    /* Need to override the base string name so it doesnt return the base type from testing code 
     * Needs to have each ingredients name and preparation instructions on a seperate line,
     * Trying to have a iteration of the ingredients while building the string with the instructions*/
    public override string ToString()
    {
        var steps = new List<string>();
        foreach (var ingredient in Ingredients)
        {
            steps.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
        }
        return string.Join(Environment.NewLine, steps);
    }
}
