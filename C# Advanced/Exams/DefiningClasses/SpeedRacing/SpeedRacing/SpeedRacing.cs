using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            List<Car> carPool = new List<Car>();
            int inputN = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputN; i++)
            {
                string[] inputLines = Console.ReadLine().Split(" ");
                string model = inputLines[0];
                double fuelAmmount = double.Parse(inputLines[1]);
                double fuelConsumptionPer1KM = double.Parse(inputLines[2]);

                Car car = new Car(model, fuelAmmount, fuelConsumptionPer1KM);

                carPool.Add(car);
            }

            string[] commands = Console.ReadLine().Split(" ");
            while (commands[0] != "End")
            {
                string model = commands[1];
                double kmToTravel = double.Parse(commands[2]);

               carPool.Where(car => car.Model == model).ToList().ForEach(car => car.isTravelPossible(kmToTravel));
               commands = Console.ReadLine().Split(" ");
            }

            foreach (var car in carPool)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
