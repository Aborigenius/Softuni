using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        //Fields
        private int engineSpeed;
        private int enginePower;
        //Constructors
        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }
        //Properties
        public int EnginePower
        {
            get { return this.enginePower; }
            set { this.enginePower = value; }
        }

        public int EngineSpeed
        {
            get { return this.engineSpeed; }
            set { this.engineSpeed = value; }
        }

    }
}
