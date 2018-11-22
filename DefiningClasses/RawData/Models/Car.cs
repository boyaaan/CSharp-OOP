using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engein engine;
        private List<Tire> tire;
        private Cargo cargo;

        public Car(string model,Engein engine, List<Tire> tire, Cargo cargo)
        {
            this.Model = model;
            this.Engein = engine;
            this.Tire = tire;
            this.Cargo = cargo;
        }

        public Engein Engein
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public List<Tire> Tire
        {
            get { return this.tire; }
            set { this.tire = value; }
        }


        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
    }
}
