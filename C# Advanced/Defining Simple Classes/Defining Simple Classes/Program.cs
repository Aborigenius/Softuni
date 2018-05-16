using System;
using Defining_Simple_Classes;

namespace Defining_Simple_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice diceD8 = new Dice();
            Dice diceD6 = new Dice();

            diceD6.Sides = 6;
            diceD6.Type = "six sided";
            diceD8.Sides = 8;
            diceD8.Type = "eight sided";

            Console.WriteLine($"Dice D6 have {diceD6.Sides} sides and its type is {diceD6.Type}");
            Console.WriteLine($"Dice D8 have {diceD8.Sides} sides and its type is {diceD8.Type}");
        }
    }
}

