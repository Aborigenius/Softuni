using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        private int Age;
        private string Name;

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
       

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public virtual void Move()
        {

        }


    }
}
