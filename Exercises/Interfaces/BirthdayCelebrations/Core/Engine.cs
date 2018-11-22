using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private ICollection<IIdentyfaible> colection;
    private ICollection<IBirthtable> colection2;

    public Engine()
    {
        this.colection = new List<IIdentyfaible>();
        this.colection2 = new List<IBirthtable>();
    }
    public void Run()
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            var inputArgument = input.Split();

            string type = inputArgument[0];

            if (type == "Robot")
            {
                string model = inputArgument[1];
                string id = inputArgument[2];

                IIdentyfaible robot = new Robot(model, id);
                this.colection.Add(robot);
            }
            else if (type == "Citizen")
            {

                string name = inputArgument[1];
                int age = int.Parse(inputArgument[2]);
                string id = inputArgument[3];
                string birthdate = inputArgument[4];

                IBirthtable citisen = new Citizen(name, age, id,birthdate);
                this.colection2.Add(citisen);
            }
            else if(type == "Pet")
            {
                string name = inputArgument[1];
                string birthdate = inputArgument[2];

                IBirthtable pet = new Pet(name, birthdate);
                colection2.Add(pet);
            }

            input = Console.ReadLine();
        }

        string year = Console.ReadLine();

        foreach (var item in this.colection2.Where(x => x.Birthdate.EndsWith(year)))
        {
            Console.WriteLine(item.Birthdate);
        }

        this.colection2 = this.colection2.Where(x => !x.Birthdate.EndsWith(year)).ToList();
    }
}

