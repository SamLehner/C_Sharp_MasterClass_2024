namespace Cookie_Cookbook.Recipes.Ingredients
{
    //Can refactor cardamon and cinnamon in the same way since they have the same instructions.

    public abstract class Spice : Ingredient
    {
        public override string PreparationInstructions =>
            $"Take half a teaspoon. {base.PreparationInstructions}";
    }
}
