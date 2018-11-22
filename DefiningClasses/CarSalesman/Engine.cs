using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private string power;
        private string displacements = @"n/a";
        private string efficiency = @"n/a";

        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public string Displacements
        {
            get { return this.displacements; }
            set { this.displacements = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }
    }
}
