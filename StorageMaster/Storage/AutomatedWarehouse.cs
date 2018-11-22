using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Vehicles;

namespace StorageMaster.Storage
{
    public class AutomatedWarehouse : Storage
    {
        private const int AutomatedWarehouseCapacity = 1;
        private const int AutomatedWarehouseGarageSlot = 1;

        private static readonly Vehicle[] DefaultVehicles =
        {
            new Truck()
        };

        public AutomatedWarehouse(string name) 
            : base(name, AutomatedWarehouseCapacity, AutomatedWarehouseGarageSlot, DefaultVehicles)
        {
        }
    }
}
