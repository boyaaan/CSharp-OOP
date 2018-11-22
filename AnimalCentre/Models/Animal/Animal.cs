using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animal
{
    public abstract class Animal
    {
        private string name;
        private int happiness;
        private int energy;
        private string procedureTime;

        protected Animal(string name, int energy, int happiness,int procedureTime)
        {
            this.Name = name;
            this.Happiness = happiness;
            this.Energy = energy;
            
        }

        public string Name { get; private set; }

        public int ProcedureTime { get; private set; }

        public string Owner => "Centre";

        public bool IsAdopt => false;

        public bool IsChipped => false;

        public bool IsVaccinated => false;

        public int Happiness
        {
            get { return happiness; }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }
                happiness = value;
            }
        }

        public int Energy
        {
            get { return energy; }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }
                energy = value;
            }
        }

    }
}
