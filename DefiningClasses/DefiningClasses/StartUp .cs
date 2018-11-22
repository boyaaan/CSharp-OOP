using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            string name = "";
            int age = 0;
            var person = new Person(name, age);

            Console.WriteLine("{0} {1}", person.Name, person.Age);
        }
    }
}
