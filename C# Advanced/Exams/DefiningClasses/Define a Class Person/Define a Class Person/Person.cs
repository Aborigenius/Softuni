using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        //Fields
        private string name;
        private int age;

        //Constructors
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int value)
        {
            this.Name = "No name";
            this.Age = value;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        //Properties
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
