using System;

namespace OldestFamilyMember
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person oldPerson = family.GetOldestMember();
            Console.WriteLine($"{oldPerson.Name} {oldPerson.Age}");
        }
    }
}
