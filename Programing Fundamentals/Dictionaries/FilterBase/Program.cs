using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> employeeAge = new Dictionary<string, int>();
            Dictionary<string, double> employeeSalary = new Dictionary<string, double>();
            Dictionary<string, string> employeePositions = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);


            while (input[0] != "filter")
            {
                string name = input[0];
                string values = input[1];
                int age = 0;
                double salary = 0;
                if (int.TryParse(input[1], out age))
                {
                    employeeAge[name] = age;
                }
                else if (double.TryParse(values, out salary))
                {
                    employeeSalary[name] = salary;
                }
                else
                {
                    employeePositions[name] = values;
                }
              input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            }
            string condition = Console.ReadLine().ToLower();
            if (condition == "position")
            {
                foreach (KeyValuePair<string, string> item in employeePositions)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (condition == "age")
            {
                foreach (KeyValuePair<string, int> item in employeeAge)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (KeyValuePair<string, double> item in employeeSalary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
