using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private AnimalFactory animalFactory;
    private List<Animal> animals;

    public Engine()
    {
        this.animalFactory = new AnimalFactory();
        this.animals = new List<Animal>();
    }
    public void Run()
    {
        string input = Console.ReadLine();

        while (input != "Beast!")
        {
            try
            {
                var type = input;
                var data = Console.ReadLine().Split();
                var name = data[0];
                var age = int.Parse(data[1]);
                var gender = data[2];

                Animal animal = animalFactory.CreatAnimal(type, name, gender, age);
                animals.Add(animal);
            }
            catch (Exception ax)
            {

                Console.WriteLine(ax.Message);
            }
            
            input = Console.ReadLine();
        }
        Print();
    }

    private void Print()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.GetType().Name);
            Console.WriteLine(animal);
            animal.ProduceSound();
        }
    }
}

