using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var result = new List<string> { "1","3","5","7","9" };
        var result2 = new List<string> { "1","3","5","7","9" };

        var result1 = result.FirstOrDefault(x => int.Parse(x) % 2 == 0) ?? result2.FirstOrDefault(y => int.Parse(y) % 2 == 0);
    }
}

