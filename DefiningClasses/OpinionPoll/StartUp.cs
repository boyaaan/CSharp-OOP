using System;
using System.Collections.Generic;

namespace OpinionPoll
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Members members = new Members();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);

                Person person = new Person(name,age);

                members.AddMembers(person);
            }

            members.GetMembers()
                .ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));

        }
    }
}
