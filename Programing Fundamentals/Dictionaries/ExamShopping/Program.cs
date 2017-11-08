using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Replace("buy", "").Split(' ');
            int price = 0;
            while (input[0] != "shopping")
            {
                string name = input[1];
                string quantity = input[2];

                if (int.TryParse(quantity, out price))
                {
                    try
                    {
                        products[name] += price;
                    }
                    catch
                    {
                        products[name] = price;
                    }
                }
                input = Console.ReadLine().Replace("buy", "").Split(' ');

            }
            input = Console.ReadLine().Replace("buy", "").Split(' ');

            while (input[0] != "exam")
            {
                string name = input[1];
                string quantity = input[2];
               
                if (!products.ContainsKey(name))
                {
                    Console.WriteLine($"{name} doesn't exist");
                }
                else if (products.ContainsKey(name))
                {
                    int stock = products[name];
                    if (stock <= 0)
                    {
                        Console.WriteLine($"{name} out of stock");
                    }
                    else if (int.TryParse(quantity, out price))
                    {
                        products[name] -= price;
                    }

                }
                input = Console.ReadLine().Replace("buy", "").Split(' ');
            }
            foreach (KeyValuePair<string, int> item in products)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
