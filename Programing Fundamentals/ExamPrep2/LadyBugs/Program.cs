using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {


        static void Main(string[] args)
        {

            int inputSize = int.Parse(Console.ReadLine());
            int[] Field = new int[inputSize];
            int[] LBindexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < LBindexes.Length; i++)
            {
                if (LBindexes[i] <= Field.Length)
                {
                    Field[LBindexes[i]] = 1;
                }

            }
            var list = Field.ToList();

            string inp = Console.ReadLine();
            while (inp != "end")
            {
                string[] input = inp.Split(' ');
                int ladybug = int.Parse(input[0]);
                string direction = input[1];
                int howMouchToMove = int.Parse(input[2]);
                int indexA = ladybug;
                if (howMouchToMove < 0)
                {
                    howMouchToMove *= -1;
                    switch (direction)
                    {
                        case "left":
                            direction = "right";
                            break;

                        case "right":
                            direction = "left";
                            break;
                    }
                }
                if (direction == "left")
                {
                    int indexB = indexA - howMouchToMove;
                    if (indexB > list.Count || indexB < list.First())
                    {
                        list[indexA] = 0;
                        goto Input;
                    }
                    if (list.ElementAt(indexB) != 0)
                    {
                        indexB += indexB;
                    }
                    //      Console.WriteLine("Moving bug {0} to {1}", indexA, indexB);
                    Swap(list, indexA, indexB);
                }
                if (direction == "right")
                {

                    int indexB = indexA + howMouchToMove;
                    if (list.ElementAt(indexB) != 0 && indexB < list.Count)
                    {
                        indexB += indexB;
                    }
                    if (indexB > list.Count || indexB > list.First())
                    {
                        list[indexA] = 0;
                        Console.WriteLine("FU!");
                    }
                    else
                    {

                        Swap(list, indexA, indexB);
                        Console.WriteLine("Moving bug {0} to {1}", indexA, indexB);
                    }


                }
                Input:
                inp = Console.ReadLine();
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Swap(List<int> list, int indexA, int indexB)
        {
            int tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }

}

