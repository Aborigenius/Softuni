using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: lastName");
                }
                if (UpperOrLower(value) == "lower")
                {
                    throw new Exception("Expected upper case letter! Argument: lastName");
                }
                this.lastName = value;
            }
        }


        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                if (UpperOrLower(value) == "lower")
                {
                    throw new Exception("Expected upper case letter! Argument: firstName");
                }
                this.firstName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public static string UpperOrLower(string names)
        {
            if (string.IsNullOrEmpty(names))
                return "bad input";

            return char.IsUpper(names[0]) ? "upper" : "lower";
        }

    }
}
