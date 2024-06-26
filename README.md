//REFERENCES
//- Troelsen, A.and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Apress.
//- Proud, Nick. 2021. "Beginner's Guide to Exception Handling in C#." YouTube video, 26:12.Posted by Nick Proud. January 21, 2021. https://www.youtube.com/watch?v=T_kOi6J0040.
//- C# 9 and .NET 5 – Modern Cross-Platform Development: Build intelligent apps, websites, and services with ASP.NET Core 5, Blazor, Entity Framework Core, and ML.NET using Visual Studio Code" by Mark J. Price.
//- C# 9.0 in a Nutshell: The Definitive Reference" by Joseph Albahari and Eric Johannsen.
//- Programming C# 8.0: Build Cloud, Web, and Desktop Applications" by Ian Griffiths.
//- C# 9.0 Pocket Reference: Instant Help for C# 9.0 Programmers" by Joseph Albahari.

#1 Recipe App

The Recipe App is an application that is console-based. This app allows users to able to manage their recipes with ease.
This includes the adding of ingredients, the scaling of recipes, resetting the quantities of ingredients as well as clearing recipes.


## Table of Contents
1. [Overview](#overview)
2. [Features](#features)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)

## Overview

The Recipe App aids users in:

- Entering and managing their recipes.
- Scaling their recipes either up or down.
- Resetting the quantities of ingredients to their original values.
- Clearing all the recipes to start over.

## Features

- **Add Recipes**: Enter a new recipe with ingredients and steps.
- **View Recipes**: Lists all the recipes and shows the details of the selected recipe.
- **Scale Recipes**: Adjusts the quantities of the ingredients based on the serving sizes.
- **Reset Quantities**: Resets the quantities of ingredients back the the values they were originally.
- **Clear Recipes**: Removes all the recipes from the app.

## Installation

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) (any edition with .NET support)
- [.NET SDK](https://dotnet.microsoft.com/download)

### Steps

1. **Clone the repository:**
    ```bash
    git clone https://github.com/apollo-xwb/ST10224391-PROG6221-POE-Part-2
    ```
2. **Go to the projects directory:**
    ```bash
    cd ST10224391-PROG6221-POE-Part-2
    ```
3. **Open the solution in Visual Studio:**
    - Double-click the `ST10224391 PROG6221 POE Part 2.sln` file in order to open it in Visual Studio.
4. **Build the solution:**
    - WHen in Visual Studio, go to `Build` > `Build Solution` or press `Ctrl+Shift+B` to build the project and resolve dependencies.
5. **Run the application:**
    - Press `Ctrl + F5` or click the `Start` button in Visual Studio to run the application.

## Usage

WHen the app is running, advance by adhering to the on-screen prompts to interact the App.

### Sample Interaction

```
Welcome to the Recipe Manager!

1. Add Recipe
2. List Recipes
3. View Recipe
4. Scale Recipe
5. Reset Quantities
6. Clear Recipes
7. Exit
Choose an option: 1

Enter recipe name: Pumkin Tart
Enter ingredient name (or 'done' to finish): Sugar
Enter quantity: 200
Enter unit: grams
Enter calories: 774
Enter food group: Carbohydrates
Enter ingredient name (or 'done' to finish): done
Enter step (or 'done' to finish): Mix all ingredients
Enter step (or 'done' to finish): Bake at 180°C for 30 minutes
Enter step (or 'done' to finish): done
Recipe added successfully!
```



## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.


