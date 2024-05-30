using System;
using System.Collections.Generic;
using System.Linq;

public class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<string> Steps { get; set; }
    public delegate void CaloriesExceededHandler(string recipeName, double totalCalories);
    public event CaloriesExceededHandler CaloriesExceeded;

    public Recipe(string name)
    {
        Name = name;
        Ingredients = new List<Ingredient>();
        Steps = new List<string>();
    }

    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
        CheckCalories();
    }

    public void AddStep(string step)
    {
        Steps.Add(step);
    }

    public void ScaleRecipe(double factor)
    {
        // Iterates through every ingredient and then scales its quantity
        foreach (var ingredient in Ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    public void ResetScale()
    {
        // Iterates through every ingredient and then has the quantity be reset to its original value
        foreach (var ingredient in Ingredients)
        {
            ingredient.ResetQuantity();
        }
    }

    public double CalculateTotalCalories()
    {
        return Ingredients.Sum(i => i.Calories * i.Quantity);
    }

    private void CheckCalories()
    {
        double totalCalories = CalculateTotalCalories();
        if (totalCalories > 300)
        {
            CaloriesExceeded?.Invoke(Name, totalCalories);
        }
    }

    public override string ToString()
    {
        string ingredientsStr = string.Join("\n", Ingredients.Select(i => i.ToString()));
        string stepsStr = string.Join("\n", Steps.Select((s, index) => $"{index + 1}. {s}"));
        return $"{Name}\nIngredients:\n{ingredientsStr}\nSteps:\n{stepsStr}";
    }
}