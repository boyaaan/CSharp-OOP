using System;
using System.Collections.Generic;
using System.Text;

public class Tomcat : Cat
{
    private const string gender = "male";

    public Tomcat(string name, int age)
        : base(name, gender, age)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("MEOW");
    }
}

