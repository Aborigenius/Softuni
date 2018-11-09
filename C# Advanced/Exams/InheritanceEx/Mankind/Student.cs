using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumer)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            LastName = lastName;
            FacultyNumber = facultyNumer;
        }

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (IsInRange(value))
                {
                    facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                    
            }
        }

        public bool IsInRange(int facultyNumber)
        {
            string checkLenght = facultyNumber.ToString();
            Console.WriteLine(checkLenght);
            if (checkLenght.Length >= 5 && checkLenght.Length <= 10)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine)
                .Append("Faculty Number: ").Append(this.FacultyNumber);

            return stringBuilder.ToString();
        }

    }
}
