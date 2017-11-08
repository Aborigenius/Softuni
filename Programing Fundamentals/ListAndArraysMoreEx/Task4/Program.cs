using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gunCylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] players = Console.ReadLine().Split(' ').ToArray();
            bool isDead = false;
            int position = 0;
            for (int i = 0; i < gunCylinder.Length; i++)
            {
                if (gunCylinder[i] == 1)
                {
                    position = 1;
                    break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                string[] tokens = players[i].Split(',');
                string direction = tokens[1];
                int power = int.Parse(tokens[0]);

                switch (direction)
                {
                    case "Right":
                        position = (position + power) % gunCylinder.Length;
                        break;
                    case "Left":
                        position = gunCylinder.Length -(Math.Abs(position - power) % gunCylinder.Length);
                        break;
                }
                if (position == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                }
                position = position + 1 == gunCylinder.Length ? 0 : position + 1;
            }
            if (isDead == false)
            {
                Console.WriteLine("Everybody got lucky");
            }
        }
    }
}
