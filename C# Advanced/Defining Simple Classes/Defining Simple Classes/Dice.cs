using System;
using System.Collections.Generic;
using System.Text;

namespace Defining_Simple_Classes
{
    class Dice
    {
        //Backing Field
        private int sides;
        public int Sides
        {
            get { return sides; }
            set { sides = value; }
        }
        //Field
        public string Type
        {
            get;
            set;
        }

        //Property
        public void Roll()
        {

        }
    }
}
