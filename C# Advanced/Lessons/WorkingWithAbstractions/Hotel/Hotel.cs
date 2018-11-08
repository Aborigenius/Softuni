using System;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PriceCalculator.Calculate(10, 5, Season.Summer, Discount.VIP));
        }
    }
}
