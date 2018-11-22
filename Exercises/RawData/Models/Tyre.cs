using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tyre
    {
        public double pressure;
        public int age;

        public Tyre(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }
    }
}
