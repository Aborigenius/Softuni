using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        //<Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” where the speed, power, weight and tire age are integers, tire preassure is a double. 

        private double pressure;
        private int tireAge;

        public Tire(double pressure, int age)
        {
            this.TireAge = age;
            this.Pressure = this.pressure;
        }

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public int TireAge
        {
            get { return this.tireAge; }
            set { this.tireAge = value; }
        }


    }
}
