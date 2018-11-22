using System;
using System.Collections.Generic;
using System.Text;

public class AnimalFactory
{
    public Animal CreatAnimal(string type, string name, string gender, int age)
    {
        type = type.ToLower();

        switch (type)
        {
            case "cat":
                return new Cat(name, gender, age);
            case "dog":
                return new Dog(name, gender, age);
            case "frog":
                return new Frog(name, gender, age);
            case "kittens":
                return new Kitten(name, age);
            case "tomcat":
                return new Tomcat(name, age);
            default:
                throw new Exception("Invalid input!");
                
        }
    }
}

