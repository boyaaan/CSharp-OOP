using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private ICollection<IBuyer> buyer;

    public Engine()
    {
        this.buyer = new List<IBuyer>();
    }

    public void Run()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine()
                .Split();

            if (input.Length == 3)
            {
                var name = input[0];
                var age = int.Parse(input[1]);
                var grup = input[2];

                IBuyer rebel = new Rebel(name, age, grup);
        
                buyer.Add(rebel);
            }
            else if (input.Length == 4)
            {
                var name = input[0];
                var age = int.Parse(input[1]);
                var id = input[2];
                var birthdate = input[3];

                IBuyer citisen = new Citizen(name, age, id, birthdate);
                buyer.Add(citisen);

                citisen.
            }
        }

        string names = string.Empty;
        while ((names = Console.ReadLine()) != "End")
        {
           buyer.Where(x => x.)
        }
    }
}

