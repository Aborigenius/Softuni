using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            double talkDoll = 3;
            double teddyBear = 4.10;
            double minion = 8.20;
            double truck = 2;
            

            double vacationPrice = double.Parse(Console.ReadLine());
            int soldPuzzles = int.Parse(Console.ReadLine());
            int soldDolls = int.Parse(Console.ReadLine());
            int soldTeddys = int.Parse(Console.ReadLine());
            int soldMinions = int.Parse(Console.ReadLine());
            int soldTrucks = int.Parse(Console.ReadLine());

            int totalToysSold = soldPuzzles + soldDolls + soldTeddys + soldMinions + soldTrucks;
            double moneyFromSales = (soldPuzzles * puzzle) + (soldDolls * talkDoll) + (soldTeddys * teddyBear) +
                (soldMinions * minion) + (soldTrucks * truck);

            if (totalToysSold >= 50)
            {
                moneyFromSales = moneyFromSales - (moneyFromSales * 0.25);
                moneyFromSales = moneyFromSales - (moneyFromSales * 0.1);
                double vacationFinal = Math.Abs(moneyFromSales - vacationPrice);
                if(moneyFromSales >= vacationPrice)
                {
                    Console.WriteLine($"Yes! {vacationFinal:f2} lv left.");
                }
                else
                {
                    
                    Console.WriteLine($"Not enough money! {vacationFinal:f2} lv needed.");
                }
            }
            else
            {
                moneyFromSales = moneyFromSales - (moneyFromSales * 0.1);
                double vacationFinal = Math.Abs(moneyFromSales - vacationPrice);
                if (moneyFromSales >= vacationPrice)
                {
                    Console.WriteLine($"Yes! {vacationFinal:f2} lv left.");
                }
                else
                {

                    Console.WriteLine($"Not enough money! {vacationFinal:f2} lv needed.");
                }
            }


        }
    }
}
