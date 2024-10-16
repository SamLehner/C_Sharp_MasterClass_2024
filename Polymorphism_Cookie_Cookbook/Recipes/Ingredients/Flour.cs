namespace Cookie_Cookbook.Recipes.Ingredients
{
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
}
