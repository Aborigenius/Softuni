using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split(' ');

                string prodKey = inputTokens[0];
                decimal prodVal = decimal.Parse(inputTokens[1]);

                if (!products.ContainsKey(prodKey) || prodVal < products[prodKey])
                {
                    products[prodKey] = prodVal;
                }

                input = Console.ReadLine();
            }

            decimal productsSum = products.Values.Sum();

     
         

            if (budget >= productsSum)
            {
                foreach (var item in products.OrderByDescending(item => item.Value)
            .ThenBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{item.Key:f2} costs {item.Value:f2}");
                }
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }


        }
    }
}
