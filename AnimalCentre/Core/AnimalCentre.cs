using AnimalCentre.Models.Animal;
using AnimalCentre.Models.Hotel;
using AnimalCentre.Models.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    
    public class AnimalCentre
    {
        private Fitness fitnes;
        private Animal animal;

        private readonly List<Animal> registry;
        
        public AnimalCentre()
        {
            this.registry = new List<Animal>();
        }
        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            

            if (registry.Any(x => x.Name == name))
            {
                throw new ArgumentException("Animal {animal name} already exist");
            }
                      
            return $"Animal {name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            
            
            return $"{name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
           return $"{name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {

          fitnes.DoService(animal, procedureTime);

            return $"{name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            return $"{name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            return $"{name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            return $"{name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            return $"{owner} adopted animal without chip";
        }

        public string History(string type)
        {
            return $"{type}";
                  

        }

    }
}
