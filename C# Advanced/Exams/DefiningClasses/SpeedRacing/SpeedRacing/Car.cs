using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        //Fields
        private string model;
        private double fuelAmmount;
        private double fuelConsumptionPer1KM;
        private double traveledDistance;

        //Constructors
        public Car(string model, double fuelAmmount, double fuelConsumptionPer1KM)
        {
            this.Model = model;
            this.FuelAmmount = fuelAmmount;
            this.FuelConsumptioPer1KM = fuelConsumptionPer1KM;
            this.TraveledDistance = 0;
        }

        //Properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmmount
        {
            get { return this.fuelAmmount; }
            set { this.fuelAmmount = value; }
        }

        public double FuelConsumptioPer1KM
        {
            get { return this.fuelConsumptionPer1KM; }
            set { this.fuelConsumptionPer1KM = value; }
        }

        public double TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }

        //Methods

        public void isTravelPossible(double kmToTravel)
        {
            if (this.fuelAmmount < this.fuelConsumptionPer1KM * kmToTravel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmmount -= this.fuelConsumptionPer1KM * kmToTravel;
                this.traveledDistance += kmToTravel;
            }
            
        }
    }
}
