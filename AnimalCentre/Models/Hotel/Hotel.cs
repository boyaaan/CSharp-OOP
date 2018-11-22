using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Hotel
{
    using Animal;
    using Contracts;

    public abstract class Hotel : IHotel
    {
        private const int Capacity = 10;
        private readonly List<Animal> animals;

        protected Hotel()
        {
            this.animals = new List<Animal>();
        }

        public IReadOnlyCollection<Animal> Animals => this.animals.AsReadOnly();

        public void Accommodate(IAnimal animal)
        {
            if (this.animals.Count < Capacity)
            {
                throw new ArgumentException("Not enough capacity");
            }
        }

        public void Adopt(string animalName, string owner)
        {

        }
    }
}
