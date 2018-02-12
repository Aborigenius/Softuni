using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    class Program
    {
        const int maxBedsInDepartment = 60;
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> departments = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Output")
            {
                var departmentName = input[0];
                var doctorNames = input[1] + " " + input[2];
                var patientName = input[3];

                if (!departments.ContainsKey(departmentName))
                {
                    departments[departmentName] = new List<string>();
                }
                if (!doctors.ContainsKey(doctorNames))
                {
                    doctors[doctorNames] = new List<string>();
                }
                if (departments[departmentName].Count >= maxBedsInDepartment)
                {
                    continue;
                }
                departments[departmentName].Add(patientName);
                doctors[doctorNames].Add(patientName);
                input = Console.ReadLine().Split();
            }
            var input1 = Console.ReadLine().Split();
            do
            {

                var searchFor = input1[0];
                var inputLenght = input1.Length;
                if (inputLenght == 1)
                {
                    if (departments.ContainsKey(searchFor))
                    {
                        departments[searchFor].ForEach(x => Console.WriteLine(x));
                    }
                    break;
                }
                if (inputLenght >= 2)
                {
                    var doctorNames = input1[0] + " " + input1[1];
                    if (doctors.ContainsKey(doctorNames))
                    {
                        doctors[doctorNames].OrderBy(x=>x).ToList().ForEach(x => Console.WriteLine(x));
                    
                    }
                    else
                    {
                        string deptmnt = input1[0];
                        int room = int.Parse(input1[1]);
                        departments[deptmnt].Skip((room * 3) - 3).Take(3).OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
                    }

                }

                input1 = Console.ReadLine().Split();
            } while (input1[0] != "End");
        }
    }
}