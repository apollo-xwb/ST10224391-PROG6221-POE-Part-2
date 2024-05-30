using System;
using System.Collections.Generic;
using System.Linq;

public class RecipeManager
{
    private List<Recipe> recipes;

    public RecipeManager()
    {
        recipes = new List<Recipe>();
    }

    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
    }

    public List<Recipe> GetRecipes()
    {
        return recipes.OrderBy(r => r.Name).ToList();
    }

    public Recipe GetRecipeByName(string name)
    {
        return recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void DisplayAllRecipes()
    {
        var sortedRecipes = GetRecipes();
        Console.WriteLine("Recipes:");
        foreach (var recipe in sortedRecipes)
        {
            Console.WriteLine(recipe.Name);
        }
    }

    public void DisplayRecipeDetails(string name)
    {
        Recipe recipe = GetRecipeByName(name);
        if (recipe != null)
        {
            Console.WriteLine(recipe.ToString());
        }
        else
        {
            Console.WriteLine("Recipe not found.");
        }
    }
}
