using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int inputN = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputN; i++)
            {
                string[] inputLines = Console.ReadLine().Split(" ");
                string name = inputLines[0];
                decimal salary = decimal.Parse(inputLines[1]);
                string position = inputLines[2];
                string department = inputLines[3];

                Employee employee = new Employee(name, salary, position, department);

                if (inputLines.Length == 5)
                {
                    if (int.TryParse(inputLines[4], out int result))
                    {
                        employee.Age = result;
                    }
                    else
                    {
                        employee.Email = inputLines[4];
                    }
                }
                else if(inputLines.Length == 6)
                {
                    int age = int.Parse(inputLines[5]);
                    employee.Email = inputLines[4];
                    employee.Age = age;
                }

                employees.Add(employee);
            }

            var topDepartment = employees.GroupBy(x => x.Department).ToDictionary(x => x.Key, y => y.Select(s => s))
                .OrderByDescending(x => x.Value.Average(s => s.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (var empl in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{empl.Name} {empl.Salary:F2} {empl.Email} {empl.Age}");
            }
        }
    }
}
