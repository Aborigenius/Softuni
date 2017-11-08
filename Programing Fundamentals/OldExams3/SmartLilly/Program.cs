using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var LillyAge = int.Parse(Console.ReadLine());
            var laundryPrice = double.Parse(Console.ReadLine());
            var toyPrice = double.Parse(Console.ReadLine());

            var toys = 0;
            var money = 0;
            var moneyrecived = 0;
            var brother = 0;
            for (int i = 1; i <= LillyAge; i++)
            {
                if (i % 2 == 0)
                {

                    brother++;
                    moneyrecived += 10;
                    money += moneyrecived;

                }
                else
                {
                    toys++;
                }
                
            }

            var moneyFromToys = toys * toyPrice;
            var takenFromBro = brother * 1;

            var allmoney = money + moneyFromToys - takenFromBro;

            var final = Math.Abs(allmoney - laundryPrice);

            if (allmoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {final:F2}");
            }
            else
            {
                Console.WriteLine($"No! {final:F2}");
            }
        }
    }
}
