using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animal
{
    using AnimalCentre.Models.Animal.Contracts;
    using AnimalCentre.Models.Procedures;
    using Contracts;

    public class Play: Procedure,IProcedure
    {

        public void DoService(Animal animal, int procedureTime)
        {
            animal.Energy -= 6;
            animal.Happiness += 12;
        }

    }
}
