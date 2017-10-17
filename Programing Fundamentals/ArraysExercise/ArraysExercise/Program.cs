using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');
            int counter = 0;
        
            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (counter == 0)
            {
                Array.Reverse(arr1);
                Array.Reverse(arr2);
                if (arr1.Length > arr2.Length)
                {
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        if (arr1[i] == arr2[i])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i] == arr2[i])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
                Console.WriteLine(counter);

        }
    }
}