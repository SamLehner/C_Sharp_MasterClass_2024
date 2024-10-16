using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Recipes
{
    //Simply a wrapper for a collection of ingredients
    public class Recipe
    {
        /*Changing it from list as having a public list is risky since anyone who uses
         * the list object has access to any method such as .Clear which we do not want.
         * We can use the IEnumerable to acheive desired result. */
        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
    }

    /* Requirements state each ingredient should have an ID, a name and preparation insturcitons. 
     * I made the Id and name abstract so that it gets over-ridden by the derived classes.
     * I made the preparation instructions have a default implementation so the derived classes
     * dont have to over-ride it. */
    public abstract class Ingredient
    {
        public abstract int Id { get; }
        public abstract string Name { get; }

        // Reminder that the => expression based defines a getter-only property
        public virtual string PreparationInstructions => "Add to other ingredients.";
    }

    // Implementing the classes we need with the requirements

    /*Saw code repetion in the classes of WheatFLour and SpeltFlour, 
     * will have them inherit from an abstract class of flour instead. */


    // Making the abstract class flour have the implementation for instructions instead of both derived classes.

    // Can also see "Add to other ingredients" is already used in the base class, we will change it to use the base class instruction.
    public abstract class Flour : Ingredient
    {
        public override string PreparationInstructions =>
            $"Sieve. {base.PreparationInstructions}";
    }
    public class WheatFlour : Flour
    {
        public override int Id => 1;
        public override string Name => "Wheat flour";

    }

    public class SpeltFlour : Flour
    {
        public override int Id => 2;
        public override string Name => "Spelt flour";

    }

    public class Butter : Ingredient
    {
        public override int Id => 3;
        public override string Name => "Butter";

        public override string PreparationInstructions =>
            $"Melt on low heat. {base.PreparationInstructions}";

    }

    public class Chocolate : Ingredient
    {
        public override int Id => 4;
        public override string Name => "Chocolate";

        public override string PreparationInstructions =>
            $"Melt in a water bath. {base.PreparationInstructions}";

    }

    // We can use the default implementation of the preparation instructions for sugar therefor we wont override it
    public class Sugar : Ingredient
    {
        public override int Id => 5;
        public override string Name => "Sugar";

    }

    //Can refactor cardamon and cinnamon in the same way since they have the same instructions.

    public abstract class Spice : Ingredient
    {
        public override string PreparationInstructions =>
            $"Take half a teaspoon. {base.PreparationInstructions}";
    }
    public class Cardamon : Spice
    {
        public override int Id => 6;
        public override string Name => "Cardomom";


    }
    public class Cinnamon : Spice
    {
        public override int Id => 7;
        public override string Name => "Cinnamon";

    }
    public class CocoaPowder : Ingredient
    {
        public override int Id => 8;
        public override string Name => "Cocoa powder";


    }
}
