using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Points: ");
            var points = double.Parse(Console.ReadLine());
            var rem = points % 2;

            var bonus100 = 5;
            var bp1000 = (points * 20 / 100);
            var bp1001 = (points * 10 / 100);
            var sum100 = (points + bonus100);
            var sum1000 = (points + bp1000);
            var sum1001 = (points + bp1001);
            
            if (rem == 0)
            {
                var sumEven = (points + 1);
                Console.WriteLine("It's even! I am adding 1 bonus point");
                Console.WriteLine(sumEven);
            }
            else if (rem == 5)

            if (points <= 100)
            {   
                Console.WriteLine($"Your Bonus Points are {bonus100}");
                Console.WriteLine($"Your Total Points are: {sum100}");
            }
            else if (points <= 1000)
            {   
                Console.WriteLine($"Your Bonus Points Are: {bp1000}");
                Console.WriteLine($"Your Total Points Are: {sum1000}");
            }
            else if (points >= 1000)
            {       
                Console.WriteLine($"Your Bonus Points Are: {bp1001}");
                Console.WriteLine($"Your Total Points Are: {sum1001}");
            }


        }
    }
}





//Percentage Formula
//number * percentage / 100
// var number = int.Parse(Console.ReadLine());
// var rem = number % 2;
// if (rem == 0)