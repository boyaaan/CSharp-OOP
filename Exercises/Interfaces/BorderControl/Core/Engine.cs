using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private ICollection<IIdentyfaible> creatable;

    public Engine()
    {
        this.creatable = new List<IIdentyfaible>();
    }

    public void Run()
    {

        string input = Console.ReadLine();

        while (input != "End")
        {
            var inputArgument = input.Split();

            if (inputArgument.Length == 2)
            {
                string model = inputArgument[0];
                string id = inputArgument[1];

                IIdentyfaible robot = new Robots(model, id);
                this.creatable.Add(robot);
            }
            else
            {

                string name = inputArgument[0];
                int age = int.Parse(inputArgument[1]);
                string id = inputArgument[2];

                IIdentyfaible citisen = new Citizens(name,age,id);
                this.creatable.Add(citisen);

                
            }

            input = Console.ReadLine();
        }

        string resultsId = Console.ReadLine();

        foreach (var item in this.creatable.Where(x => x.Id.EndsWith(resultsId)))
        {
            Console.WriteLine(item.Id); 
        }

        this.creatable = this.creatable.Where(x => !x.Id.EndsWith(resultsId)).ToList();
    }
}

