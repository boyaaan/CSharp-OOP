using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private string engine;
        private string weight = @"n/a";
        private string color = @"n/a";

        public Car(string model, string engine)
        {
            this.Model = model;
            this.Engin = engine;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Engin
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }
}
