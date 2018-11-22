using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var phonesNums = Console.ReadLine()
            .Split()
            .ToList();


        var urls = Console.ReadLine()
            .Split()
            .ToList();


        var smartPhone = new Smartphone();

        for (int i = 0; i < phonesNums.Count; i++)
        {
            smartPhone.Call(phonesNums[i]);
        }

        for (int i = 0; i < urls.Count; i++)
        {
            smartPhone.Browse(urls[i]);
        }
    }
}
