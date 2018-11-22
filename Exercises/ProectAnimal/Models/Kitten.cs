using System;
using System.Collections.Generic;
using System.Text;

public class Kitten : Cat
{
    private const string gender = "female";

    public Kitten(string name, int age) 
        : base(name, gender, age)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }
}


