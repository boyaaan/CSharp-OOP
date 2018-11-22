using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Controller
{
    using Products;
    using System.Linq;
    using System;
    using System.Reflection;
    

    public class Engine : StorageMaster
    {
        
        public void Run()
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                try
                {
                    var commandResult = ProcessCommand(command);
                    Console.WriteLine(commandResult);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            var summary = GetSummary();
            Console.WriteLine(summary);
        }

        private string ProcessCommand(string command)
        {
            var commandArgs = command.Split(' ');
            var commandName = commandArgs[0];
            var args = commandArgs.Skip(1).ToArray();

            var output = string.Empty;
            switch (commandName)
            {
                case "AddProduct":
                    {
                        var name = args[0];
                        var price = double.Parse(args[1]);

                        output = AddProduct(name, price);
                        break;
                    }
                case "RegisterStorage":
                    {
                        var type = args[0];
                        var name = args[1];

                        output = RegisterStorage(type, name);
                        break;
                    }
                case "SelectVehicle":
                    {
                        var storageName = args[0];
                        var garageSlot = int.Parse(args[1]);

                        output = SelectVehicle(storageName, garageSlot);
                        break;
                    }
                case "LoadVehicle":
                    {
                        var productNames = args;

                        output = LoadVehicle(productNames);
                        break;
                    }
                case "SendVehicleTo":
                    {
                        var sourceName = args[0];
                        var sourceGarageSlot = int.Parse(args[1]);
                        var destinationName = args[2];

                        output = SendVehicleTo(sourceName, sourceGarageSlot, destinationName);
                        break;
                    }
                case "UnloadVehicle":
                    {
                        var sourceName = args[0];
                        var garageSlot = int.Parse(args[1]);

                        output = UnloadVehicle(sourceName, garageSlot);
                        break;
                    }
                case "GetStorageStatus":
                    {
                        var storageName = args[0];
                        output = GetStorageStatus(storageName);
                        break;
                    }
            }

            return output;
        }
    }

   
}
