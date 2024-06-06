using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static PROYECT.recipe;

namespace PROYECT
{
    public class recipe
    {
        public string Namer  {get; set; }
        public Ingredient[] Ingredients { get; set; }
        public int Calories { get; private set; }

        // Constructor que no recibe parametros3
        public recipe()
        {
            Ingredients = new Ingredient[0];
        }

        // Constructor que recibe el número de ingredientes
        public recipe(string namer, int numberOfIngredients)
        {
            Namer = namer;
            Ingredients = new Ingredient[numberOfIngredients];
        }

        // Constructor que recibe un arreglo de ingredientes
        public recipe(string namer, Ingredient[] ingredients)
        {
            Namer = namer;
            Ingredients = ingredients;
            CalcularCalories();
        }

        // Método que no recibe parametros pero regresa algo
        public int CalcularCalories()
        {
            int totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                if (ingredient != null) 
                {
                    totalCalories += ingredient.Calories;
                }
            }
            return totalCalories;
        }
    }
}

