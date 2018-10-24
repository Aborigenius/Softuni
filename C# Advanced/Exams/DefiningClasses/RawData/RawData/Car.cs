using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        //Fields
        private string model;
        private Engine _engine;
        private Cargo _cargo;
        private List<Tire> _tires;

        //Constructors
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        //Properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        public Cargo Cargo
        {
            get { return this._cargo; }
            set { this._cargo = value; }
        }

        public List<Tire> Tires
        {
            get { return _tires; }
            set { _tires = value; }
        }
        //Methods
    }
}
