namespace Cookie_Cookbook.Recipes.Ingredients
{
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

        //Need to override the base toString method for the requirements of showing Id and Name of ingredient
        public override string ToString() => $"{Id}. {Name}";
    }
}
