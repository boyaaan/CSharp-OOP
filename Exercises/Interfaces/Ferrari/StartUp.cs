using System;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            ICar result = new Ferrari(name);

            Console.WriteLine($"{result.Model}/{result.Stop()}/{result.Start()}/{result.Driver}");
        }
    }
}
