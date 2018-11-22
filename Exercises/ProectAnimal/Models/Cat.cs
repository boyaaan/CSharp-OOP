using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Animal
{
    public Cat(string name, string gender, int age)
        : base(name, gender, age)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow meow");
    }
}

