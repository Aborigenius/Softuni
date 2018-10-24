using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        //Fields
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        //Constructors
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
        //Properties
        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        //Methods
    }
}