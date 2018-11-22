using System;
using System.Collections.Generic;
using System.Linq;


namespace ExercisesGenerics.Core
{
    using Interfaces;

    public class Engine
    {
        public void Run()
        {

            var myList = new Box<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var command = input
                    .Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                switch (command[0])
                {
                    case "Add":
                        var curInput = command.Skip(1).ToArray();
                        myList.Add(curInput[0]);
                        break;
                    case "Max":
                        Console.WriteLine(myList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(myList.Min());
                        break;
                    case "Greater":
                        Console.WriteLine(myList.CompareElement(command[1]));
                        break;
                    case "Swap":
                        myList.Swap(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Contains":
                        Console.WriteLine(myList.Contains(command[1]));
                        break;
                    case "Print":
                        myList.Print();
                        break;
                    case "Remove":
                        myList.Remove(int.Parse(command[1]));
                        break;
                    case "Sort":
                        myList.Sort();
                        break;

                }
            }
        }
    }
}
