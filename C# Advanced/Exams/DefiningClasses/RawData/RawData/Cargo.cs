using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        //Fields
        private int cargoWeight;
        private string cargoType;
        //Constructors
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
        //Properties
        public string CargoType
        {
            get { return this.cargoType; }
            set { cargoType = value; }
        }

        public int CargoWeight
        {
            get { return cargoWeight; }
            set { cargoWeight = value; }
        }
        //Methods

    }
}
