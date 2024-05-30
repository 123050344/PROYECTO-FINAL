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
        public string Namer { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int Calories { get; private set; }

        //Constructor que no recibe parametros
        public recipe()
        {
            Ingredients = new List<Ingredient>();
        }

        // Constructor que recibe parámetros
        public recipe(string namer, List<Ingredient> ingredients)
        {
            Namer = namer;
            Ingredients = ingredients;
            CalcularCalories();
        }

        public class Ingredient
        {
            // Propiedades de lectura y escritura
            public string Namei { get; set; }
            public int Quantity { get; set; }


            // Propiedad solo de lectura
            public int Calories { get; private set; }

            // Propiedad de solo escritura
            public int Weight { private get; set; }


            // Constructor que recibe parametros
            public Ingredient(string namei, int quantity, int calories)
            {
                Namei = namei;
                Quantity = quantity;
                Calories = calories;
            }

            // Método que no recibe parámetros ni regresa nada
            public void ShowInformation()
            {
                Console.WriteLine($"Ingredient: {Namei}, Quantity: {Quantity}, Caloríes: {Calories}");
            }
        }

        public recipe(List<Ingredient> ingredients)
        {

            Ingredients = ingredients;
            CalcularCalories();
        }

        // Método que no recibe parametros pero regresa algo
        public int CalcularCalories()
        {
            int totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }

        // Método que recibe parámetros y regresa algo
        public int TotalIngredientes(int totalingre)
        {
            int totalIngredients = 0;
            foreach (var ingredient in Ingredients)
            {
                totalIngredients += ingredient.Quantity;
            }
            return totalIngredients * totalingre;
        }
    }
}

