using System;
using System.Collections.Generic;
using System.Linq;

namespace ProdutcsShop
{
    class ProdutcsShop
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] productsInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);


            while (productsInfo[0] != "Revision")
            {
                string shop = productsInfo[0];
                string product = productsInfo[1];
                double price = double.Parse(productsInfo[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop][product] = price;
                }
                productsInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            // var result = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}