using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LseeonDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>
            {
                ["Pesho"] = 3,
                ["Gosho"] = 4,
                ["Maria"] = 6,
                ["Ivan"] = 2,
                ["Ivo"] = 2
            };

            //sorting
            // students.OrderBy(s => s.Value).ToDictionary(key => key.Key, val => val.Value);

            // Sorting with Foreach
            foreach (KeyValuePair<string, int> student in students
                .OrderByDescending(s => s.Value).ThenByDescending(s => s.Key.Length))
            {
                Console.WriteLine(student.Key + " => " + student.Value);
            }
        }
    }
}
