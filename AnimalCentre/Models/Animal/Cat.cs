using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animal
{
    using AnimalCentre.Models.Contracts;
    using Contracts;

    public class Cat : Animal,IAnimal
    {
        public Cat(string name, int energy, int happiness, int procedureTime)
            : base(name, energy, happiness, procedureTime)
        {
        }
                
        public string ToString()
        {
            return $"Animal type: {GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }

        
    }
}
