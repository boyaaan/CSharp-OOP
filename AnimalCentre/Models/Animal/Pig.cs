using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animal
{
    using AnimalCentre.Models.Contracts;
    using Contracts;

    public class Pig : Animal,IAnimal
    {
        public Pig(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }

        Pig pig;
        public string ToString()
        {
            return $"Animal type: {pig.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }

       
    }
}
