using System;

public class Ingredient
{
    public string Name { get; set; }
    public double Quantity { get; set; }
    public double OriginalQuantity { get; set; } // Adds The OriginalQuantity property in
    public string Unit { get; set; }
    public double Calories { get; set; }
    public string FoodGroup { get; set; }

    public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
    {
        Name = name;
        Quantity = quantity;
        OriginalQuantity = quantity; // Sets The OriginalQuantity in constructor
        Unit = unit;
        Calories = calories;
        FoodGroup = foodGroup;
    }

    public void ResetQuantity()
    {
        // Resets the quantity to its original value
        Quantity = OriginalQuantity;
    }

    public override string ToString()
    {
        return $"{Name}: {Quantity} {Unit}, {Calories} calories, {FoodGroup}";
    }
}