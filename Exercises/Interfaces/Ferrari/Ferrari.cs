using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model { get ; }
        public string Driver { get; }

        public string Start()
        {
            return "Zadu6avam sA!";
        }

        public string Stop()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Stop()}/{this.Start()}/{this.Driver}";
        }
    }
}
