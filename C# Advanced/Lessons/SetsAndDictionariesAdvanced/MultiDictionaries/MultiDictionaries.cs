using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiDictionaries
{
    class MultiDictionaries
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
        

            int studentsNumber = 0;
            studentsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsNumber; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (grades.ContainsKey(input[0]))
                {
                    grades[input[0]].Add(Double.Parse(input[1]));
                }
                else
                {
                    grades[input[0]] = new List<double>()
                    {
                        double.Parse(input[1])
                    };
                }
            }
            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value)} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
