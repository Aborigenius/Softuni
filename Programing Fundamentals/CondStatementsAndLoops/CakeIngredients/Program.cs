using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingCounter = 0;
            for (int i = 0; i <= 20; i++)
            {
               
                string ingredient = Console.ReadLine();
                ingCounter++;
                if (ingredient == "Bake!")
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    ingCounter--;
                    Console.WriteLine($"Preparing cake with {ingCounter} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
            }
        }
    }
}
