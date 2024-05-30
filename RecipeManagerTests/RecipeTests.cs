using System;
using Xunit;

public class RecipeTests
{
    [Fact]
    public void AddIngredient_ShouldUpdateTotalCalories()
    {
        // Arrange
        Recipe recipe = new Recipe("Test Recipe");

        Ingredient ingredient1 = new Ingredient("Sugar", 100, "grams", 3.87, "Carbohydrates");
        Ingredient ingredient2 = new Ingredient("Butter", 50, "grams", 7.17, "Fats");

        // Act
        recipe.AddIngredient(ingredient1);
        recipe.AddIngredient(ingredient2);
        double totalCalories = recipe.CalculateTotalCalories();

        // Assert
        Assert.Equal(745.5, totalCalories); // 3.87 * 100 + 7.17 * 50 = 387 + 357.5 = 744.5
    }

    [Fact]
    public void AddIngredient_ShouldTriggerCaloriesExceededEvent()
    {
        // Arrange
        Recipe recipe = new Recipe("Test Recipe");
        bool eventTriggered = false;

        recipe.CaloriesExceeded += (name, calories) => { eventTriggered = true; };

        Ingredient ingredient = new Ingredient("Sugar", 500, "grams", 2.0, "Carbohydrates");

        // Act
        recipe.AddIngredient(ingredient);
        recipe.CalculateTotalCalories();

        // Assert
        Assert.True(eventTriggered);
    }

    [Fact]
    public void ResetScale_ShouldReturnOriginalValues()
    {
        // Arrange
        Recipe recipe = new Recipe("Test Recipe");
        Ingredient ingredient = new Ingredient("Flour", 100, "grams", 3.64, "Carbohydrates");
        recipe.AddIngredient(ingredient);

        // Act
        recipe.ScaleRecipe(2); // Scale by factor of 2
        recipe.ResetScale();   // Reset the scale

        // Assert
        Assert.Equal(100, recipe.Ingredients[0].Quantity);
    }

    [Fact]
    public void CalculateTotalCalories_ShouldReturnCorrectValue()
    {
        // Arrange
        Recipe recipe = new Recipe("Test Recipe");
        Ingredient ingredient1 = new Ingredient("Sugar", 100, "grams", 3.87, "Carbohydrates");
        Ingredient ingredient2 = new Ingredient("Butter", 50, "grams", 7.17, "Fats");

        // Act
        recipe.AddIngredient(ingredient1);
        recipe.AddIngredient(ingredient2);
        double totalCalories = recipe.CalculateTotalCalories();

        // Assert
        Assert.Equal(745.5, totalCalories); // (3.87 * 100) + (7.17 * 50)
    }
}
