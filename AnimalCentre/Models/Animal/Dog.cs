using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animal
{
    
using AnimalCentre.Models.Contracts;

    public class Dog : Animal,IAnimal
    {
        public Dog(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }

        Dog dog;
        public string ToString()
        {
            return $"Animal type: {dog.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }

       
    }
}
