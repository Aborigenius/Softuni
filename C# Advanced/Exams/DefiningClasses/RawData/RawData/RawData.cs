using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class RawData
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ");
                string model = inputTokens[0];
                int engineSpeed = int.Parse(inputTokens[1]);
                int enginePower = int.Parse(inputTokens[2]);
                int cargoWeight = int.Parse(inputTokens[3]);
                string cargoType = inputTokens[4];
                List<Tire> tires = new List<Tire>();
                for (int j = 0; j < 4; j += 2)
                {
                    double tirePressure = double.Parse(inputTokens[5 + j]);
                    int tireAge = int.Parse(inputTokens[6 + j]);

                    int tireAge1 = tireAge;
                    Tire tire = new Tire(tirePressure, tireAge1);
                    tires.Add(tire);

                    Engine engine = new Engine(engineSpeed, engineSpeed);
                    Cargo cargo = new Cargo(cargoWeight, cargoType);

                    Car car = new Car(model, engine, cargo, tires);
                    cars.Add(car);
                }
            }

            string command = Console.ReadLine();
            List<Car> result = new List<Car>();

            if (command == "fragile")
            {
                result = cars.Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList();

            }
            else
            {
                result = cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250).ToList();
            }

            foreach (var car in result)
            {
                Console.WriteLine(car.Model);
            }

        }
    }
}