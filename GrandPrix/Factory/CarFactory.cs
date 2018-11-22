using GrandPrix.Entities.Cars;
using GrandPrix.Entities.Tyres;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Factory
{
    
    public static class CarFactory
    {
        public static Car Create(List<string> args, Tyre tyre)
        {
            var hp = int.Parse(args[0]);
            var fuelAmount = double.Parse(args[1]);

            return new Car(hp, fuelAmount, tyre);
        }
    }
}
