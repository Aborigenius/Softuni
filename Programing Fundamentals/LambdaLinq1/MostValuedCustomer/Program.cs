using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostValuedCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double> products = new Dictionary<string, double>();

            while (input != "Shop is open")
            {
                string[] inputTokens = input.Split(' ');
                string productName = inputTokens[0];
                double productPrice = double.Parse(inputTokens[1]);

                products[productName] = productPrice;
                input = Console.ReadLine();
            }
            string orders = Console.ReadLine();
 
            var buyersData = new Dictionary<string, List<string>>();
            while (orders != "Print")
            {
                string[] inputOrders = orders.Split(new string[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                string buyer = inputOrders[0];
     
                if (orders == "Discount")
                {
                   var discountProducts = products.OrderByDescending(x => x.Value)
                        .Take(3).Select(x => new KeyValuePair<string, double>
                        (x.Key, x.Value * 0.9));
                    foreach (var dp in discountProducts)
                    {
                        products[dp.Key] = dp.Value;
                    }
             
                }
                else
                {
                    if (!buyersData.ContainsKey(buyer))
                    {
                        buyersData.Add(buyer, new List<string>());
                        for (int i = 1; i < inputOrders.Length; i++)
                        {
                            string boughtProduct = inputOrders[i];
                            if (products.ContainsKey(boughtProduct))
                            {
                                buyersData[buyer].Add(boughtProduct);
                            }
                        }
                    }
                }

                orders = Console.ReadLine();
            }


            var topCustomer = buyersData
                .OrderByDescending(d => d.Value.Sum(product => products[product]))
                .First();

            string name = topCustomer.Key;
            List<string> prb = topCustomer.Value;

            Console.WriteLine("Biggest spender: {0}", name);
            Console.WriteLine("^Products bought:");
            double totalSpent = prb.Sum(pr => products[pr]);
            var orderedProducts = prb.Distinct().OrderByDescending(p => products[p]);
            foreach (var item in orderedProducts)
            {
                Console.WriteLine("^^^{0}: {1:F2}", item, products[item]);
            }
            Console.WriteLine("Total: {0:F2}", totalSpent);
        }
    }
}
//da e jiv i zdrav Preslav
