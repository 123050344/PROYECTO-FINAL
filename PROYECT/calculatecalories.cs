using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PROYECT.recipe;

namespace PROYECT
{
    internal class calculatecalories:recipe
    {

        // Método estático, que si tiene parametros y regresa algo
        public static int addcalories(List<Ingredient> ingredients)
        {
                int totalCalories = 0;
                foreach (var ingredient in ingredients)
                {
                    totalCalories += ingredient.Calories;
                }
                return totalCalories;
        }
        
    }
}
