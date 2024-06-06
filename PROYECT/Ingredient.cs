using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECT
{
    public class Ingredient:recipe
    {
        // Propiedades de lectura y escritura
        public string Namei { get; set; }
        public int Quantity { get; set; }


        // Propiedad solo de lectura
        public int Calories { get; private set; }


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
}
