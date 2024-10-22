
//Starting with the main data for the program, will work on implementation with clean code following this

using Cookie_Cookbook.App;
using Cookie_Cookbook.DataAccess;
using Cookie_Cookbook.FileAccess;
using Cookie_Cookbook.Recipes;
using Cookie_Cookbook.Recipes.Ingredients;
using System.Runtime.CompilerServices;
using System.Text.Json;


const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();
const string FileName = "recipes";
var fileMetadata = new FileMetadata(FileName, Format);

var ingredientsRegister = new IngredientsRegister();


var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(
        new StringsJsonRepository(),
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister));

cookiesRecipesApp.Run(fileMetadata.ToPath());

