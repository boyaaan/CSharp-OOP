using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Factories
{
    using System.Linq;
    using System.Reflection;
    using Vehicles;

    public class VahicleFactoty
    {
        public Vehicle CreateVehicle(string type)
        {
            var vehicleType = this.GetType()
                .Assembly
                .GetTypes()
                .FirstOrDefault(t => typeof(Vehicle).IsAssignableFrom(t) && !t.IsAbstract && t.Name == type);

            if (vehicleType == null)
            {
                throw new InvalidOperationException("Invalid vehicle type!");
            }

            try
            {
                var storage = (Vehicle)Activator.CreateInstance(vehicleType);
                return storage;
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}
