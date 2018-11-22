using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone : IBroseble, ICalling
{
    public void Browse(string url)
    {
        if (!url.Any(x => char.IsDigit(x)))
        {
            Console.WriteLine($"Browsing: {url}!");
        }
        else 
        {
            Console.WriteLine("Invalid URL!");
        }
    }

    public void Call(string numbers)
    {
        if (numbers.All(x => char.IsDigit(x)))
        {
            Console.WriteLine($"Calling... {numbers}");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

