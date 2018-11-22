using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animal
{
    using AnimalCentre.Models.Animal.Contracts;
    using AnimalCentre.Models.Contracts;
    using AnimalCentre.Models.Procedures;
    
    
    public class Chip : Procedure, IProcedure
    {
        

        public void DoService(Animal animal, int procedureTime)
        {
            animal.Happiness -= 5;

            if (animal.ProcedureTime >= procedureTime)
            {
                
            }
            else
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }
        }
    }
}
