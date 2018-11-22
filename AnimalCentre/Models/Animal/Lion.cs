using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animal
{
    using AnimalCentre.Models.Contracts;
    using Contracts;

    public class Lion : Animal,IAnimal
    {
        public Lion(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }

        Lion lion;
        public string ToString()
        {
            return $"Animal type: {lion.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
