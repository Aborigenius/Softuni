using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinkName = Console.ReadLine();
            var drinkVoulme = int.Parse(Console.ReadLine());
            var energyContentPer100ml = int.Parse(Console.ReadLine());
            var sugarContentPer100ml = int.Parse(Console.ReadLine());

            var kcals = energyContentPer100ml / 100.0 * drinkVoulme;
            var sugars = sugarContentPer100ml * drinkVoulme /  100.0;

            Console.WriteLine($"{drinkVoulme}ml {drinkName}:");
            Console.WriteLine($"{kcals}kcal, {sugars}g sugars");


        }
    }
}
