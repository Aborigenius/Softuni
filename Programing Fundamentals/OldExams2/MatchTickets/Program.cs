using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldExams
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = (Console.ReadLine());
            var peopleInGroup = int.Parse(Console.ReadLine());
            var moneyLeft = budget;
            var ticketPrice = 0.00;


            if (peopleInGroup < 5)
            {
                moneyLeft -= budget * 0.75;
                if (category == "VIP")
                {
                    ticketPrice = 499.99;
                }
                if (category == "Normal")
                {
                    ticketPrice = 249.99;
                }
            }
            if (peopleInGroup >= 5 && peopleInGroup < 10)
            {
                moneyLeft -= budget * 0.60;
                if (category == "VIP")
                {
                    ticketPrice = 499.99;
                }
                if (category == "Normal")
                {
                    ticketPrice = 249.99;
                }
            }
            if (peopleInGroup >= 11 && peopleInGroup < 25)
            {
                if (category == "VIP")
                {
                    ticketPrice = 499.99;
                }
                if (category == "Normal")
                {
                    ticketPrice = 249.99;
                }
                moneyLeft -= budget * 0.50;
            }
            if (peopleInGroup >= 25 && peopleInGroup < 50)
            {
                moneyLeft -= budget * 0.45;
                if (category == "VIP")
                {
                    ticketPrice = 499.99;
                }
                if (category == "Normal")
                {
                    ticketPrice = 249.99;
                }
            }
            else
            {
                moneyLeft -= budget * 0.25;
                if (category == "VIP")
                {
                    ticketPrice = 499.99;
                }
                if (category == "Normal")
                {
                    ticketPrice = 249.99;
                }
            }
            var final = peopleInGroup * ticketPrice;

            if (final > moneyLeft)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", final - moneyLeft);
            }
            else
            {
                moneyLeft -= final;
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
            }
        }
    }
}