using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Vehicles;

namespace StorageMaster.Storage
{
    using Vehicles;

    public class DistributionCenter : Storage
    {
        private const int DistributionCenterCapacity = 2;
        private const int DistributionCenterGarageSlot = 5;

        private static readonly Vehicle[] defaultVehicle =
        {
            new Van(), new Van(), new Van()
        };

        public DistributionCenter(string name)
            : base(name, DistributionCenterCapacity, DistributionCenterGarageSlot, defaultVehicle)
        {
        }
    }

}





