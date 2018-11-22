using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Animal.Contracts;
    using Animal;
    using AnimalCentre.Models.Contracts;

    public class Fitness : Procedure, IProcedure
    {
        public void DoService(Animal animal, int procedureTime)
        {
            animal.Happiness -= 3;
            animal.Energy += 10;

        }
        
    }
}
