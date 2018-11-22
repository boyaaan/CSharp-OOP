using System;
using System.Globalization;
using System.Linq;

namespace DateCalculate
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var date1 = Console.ReadLine().Split();
            var date2 = Console.ReadLine().Split();
            var firstDate = date1[2] + "/" + date1[1] + "/" + date1[0];
            var secondDate = date2[2] + "/" + date2[1] + "/" + date2[0];

            DateModifier date = new DateModifier(firstDate,secondDate);

            var result = date.DateCalculate();
            Console.WriteLine(result);
        }
    }
}
