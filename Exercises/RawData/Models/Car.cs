using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tyre> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tyre> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }
    }
}
