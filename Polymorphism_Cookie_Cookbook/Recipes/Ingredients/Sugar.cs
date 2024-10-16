namespace Cookie_Cookbook.Recipes.Ingredients
{
    // We can use the default implementation of the preparation instructions for sugar therefor we wont override it
    public class Sugar : Ingredient
    {
        public override int Id => 5;
        public override string Name => "Sugar";

    }
}
