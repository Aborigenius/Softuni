using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameTime = false;
            double gamePrice = 0;
            double totalSpent = 0;
            double currentBalance = Double.Parse(Console.ReadLine());
            while (currentBalance >= 0 || gameTime == true)
            {
                string gameTitle = Console.ReadLine();
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                }
                if (gameTitle == "Game Time")
                {
                    Console.WriteLine($"Total Spent:{totalSpent:f2}. Remaining: {currentBalance:f2}");
                    gameTime = false;
                    break;
                }

                else if (gameTitle == "Outfall 4" || gameTitle == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                    totalSpent += 39.99;
                    currentBalance -= gamePrice;
                }
                else if (gameTitle == "Honored 2")
                {
                    gamePrice = 59.99;
                    totalSpent += 59.99;
                    currentBalance -= gamePrice;
                }
                else if (gameTitle == "RoverWatch")
                {
                    gamePrice = 29.99;
                    totalSpent += 29.99;
                    currentBalance -= gamePrice;
                }
                else if (gameTitle == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    totalSpent += 19.99;
                    currentBalance -= gamePrice;
                }
                else if (gameTitle == "CS: OG")
                {
                    totalSpent += 15.99;
                    gamePrice = 15.99;
                    currentBalance -= gamePrice;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                if (currentBalance < gamePrice)
                {
                    Console.WriteLine("Too expensive");
                    
                }


            }

        }
    }
}
