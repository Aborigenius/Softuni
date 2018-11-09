using System;

namespace Mankind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputStudent = Console.ReadLine().Split(" ");
            string firstNameS = inputStudent[0];
            string lastNameS = inputStudent[1];
            int facultyNumber = int.Parse(inputStudent[2]);

            Student student = new Student(firstNameS, lastNameS, facultyNumber);

            string [] inputWorker = Console.ReadLine().Split(" ");
            string firstNameW = inputWorker[0];
            string lastNameW = inputWorker[1];
            decimal weeklySalary = decimal.Parse(inputWorker[2]);
            double workingHoursPerDay = double.Parse(inputWorker[3]);

            Console.WriteLine(student);

        }
    }
}
