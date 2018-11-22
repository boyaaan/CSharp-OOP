using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Startup
    {
        public static void Main()
        {
            List<Car> allCars = new List<Car>();
            List<Engine> allEngines = new List<Engine>();

            int countEngies = int.Parse(Console.ReadLine());

            for (int i = 0; i < countEngies; i++)
            {
                var input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = input[0];
                var cuEngine = input[1];

                Engine engine = new Engine(model, cuEngine);

                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int result))
                    {
                        engine.Displacements = input[2];
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }

                }
                else if (input.Length == 4)
                {
                    if (int.TryParse(input[2], out int result))
                    {
                        engine.Displacements = input[2];
                        engine.Efficiency = input[3];

                    }
                    else
                    {
                        engine.Displacements = input[3];
                        engine.Efficiency = input[2];
                    }

                }

                allEngines.Add(engine);
            }

            int countCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCars; i++)
            {
                var input = Console.ReadLine().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = input[0];
                var cuEngine = input[1];

                Car cars = new Car(model, cuEngine);

                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int result))
                    {
                        cars.Weight = input[2];
                    }
                    else
                    {
                        cars.Color = input[2];
                    }

                }
                else if (input.Length == 4)
                {
                    if (int.TryParse(input[2], out int result))
                    {
                        cars.Weight = input[2];
                        cars.Color = input[3];

                    }
                    else
                    {
                        cars.Weight = input[3];
                        cars.Color = input[2];
                    }
                }

                allCars.Add(cars);
            }

            foreach (var car in allCars)
            {
                Console.WriteLine(car.Model+":");
                Console.WriteLine($"  {car.Engin}:");

                foreach (var engin in allEngines)
                {
                    if (engin.Model != car.Engin)
                    {
                        continue;
                    }

                    Console.WriteLine($"    Power: {engin.Power}");
                    Console.WriteLine($"    Displacement: {engin.Displacements}");
                    Console.WriteLine($"    Efficiency: {engin.Efficiency}");
                }

                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
