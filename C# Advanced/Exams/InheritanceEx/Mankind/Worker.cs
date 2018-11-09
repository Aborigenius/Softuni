using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;
        //. It should be able to calculate the money he earns by an hour

        public Worker(string firstName, string lastName, decimal weekSalary, double workingHours)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (IsInRange(value))
                {
                    workHoursPerDay = value;
                }
                else
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
            }
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch!Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        public bool IsInRange(double workingHours)
        {
            string checkLenght = workingHours.ToString();
            Console.WriteLine(checkLenght);
            if (checkLenght.Length >= 1 && checkLenght.Length <= 12)
            {
                return true;
            }
            return false;
        }

    }

}

