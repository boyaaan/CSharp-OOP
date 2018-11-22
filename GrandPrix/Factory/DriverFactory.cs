using GrandPrix.Entities.Cars;
using GrandPrix.Entities.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Factory
{
    public static class DriverFactory
    {
        public static Driver Create(List<string> args, Car car)
        {
            var type = args[0];
            var name = args[1];

            switch (type)
            {
                case "Aggressive":
                    return new AggressiveDriver(name, car);
                case "Endurance":
                    return new EnduranceDriver(name, car);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
