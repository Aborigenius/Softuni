using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> enginesList = new List<Engine>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                string[] inputTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputTokens[0];
                int power = int.Parse(inputTokens[1]);

                Engine engine = new Engine(model, power);
                if (inputTokens.Length == 3)
                {
                    if (inputTokens[2].All(Char.IsDigit))
                    {
                        engine.Displacement = inputTokens[2];
                    }
                    else
                    {
                        engine.Efficiency = inputTokens[2];
                    }
                }
                else if (inputTokens.Length == 4)
                {
                    engine.Displacement = inputTokens[2];
                    engine.Efficiency = inputTokens[3];
                }
                enginesList.Add(engine);
            }

            int M = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();
            for (int i = 0; i < M; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputTokens[0];
                Engine engine = enginesList.First(e => e.Model == inputTokens[1]);
                Car car = new Car(model, engine);
                if (inputTokens.Length == 3)
                {
                    if (inputTokens[2].All(Char.IsDigit))
                    {
                        car.Weight = inputTokens[2];
                    }
                    else
                    {
                        car.Color = inputTokens[2];
                    }
                }
                if (inputTokens.Length == 4)
                {
                    car.Weight = inputTokens[2];
                    car.Color = inputTokens[3];
                }
                carsList.Add(car);
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model}:{System.Environment.NewLine}  {car.Engine.Model}:{System.Environment.NewLine}    Power: {car.Engine.Power}" +
                    $"{System.Environment.NewLine}    Displacement: {car.Engine.Displacement}{System.Environment.NewLine}    Efficiency: {car.Engine.Efficiency}" +
                    $"{System.Environment.NewLine}  Weight: {car.Weight}{System.Environment.NewLine}  Color: {car.Color}");
            }
        }
    }
}
