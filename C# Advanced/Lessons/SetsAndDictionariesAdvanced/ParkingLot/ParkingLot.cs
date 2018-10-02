using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string direction = input[0];
            string licensePlate = input[1];
            HashSet<string> cars = new HashSet<string>();

            while (input[0]?.ToLower() != "end")
            {
                direction = input[0];
                licensePlate = input[1];
                switch (direction?.ToLower())
                {
                    case "in":
                        cars.Add(licensePlate);
                        break;
                    case "out":
                        cars.Remove(licensePlate);
                        break;
                }
                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray(); 
            }


            if (cars.Count > 0)
            {
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
