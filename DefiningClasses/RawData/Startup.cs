using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RawData
{
    public class Startup
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var model = input[0];
                var speed = int.Parse(input[1]);
                var power = int.Parse(input[2]);
                var wight = int.Parse(input[3]);
                var type = input[4];

                List<Tire> tire = new List<Tire>();

                for (int j = 0; j < 4; j += 2)
                {
                    double pressure = double.Parse(input[5 + j]);
                    int age = int.Parse(input[6 + j]);

                    tire.Add(new Tire(age, pressure));
                }

                Engein engin = new Engein(speed, power);

                Cargo cargo = new Cargo(wight,type);

                Car car = new Car(model,engin,tire,cargo);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            List<Car> result = new List<Car>();

            if (command == "fragile")
            {
                result = cars.Where(x => x.Cargo.Type == "fragile" && x.Tire.Any(s => s.Pressure < 1)).ToList() ;
                   
            }
            else if (command == "flamable")
            {
                result = cars.Where(x => x.Cargo.Type == "flamable" && x.Engein.Power > 250).ToList();
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.Model);
            }
        }
    }
}
