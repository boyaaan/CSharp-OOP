using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    using Contracts;
    using Animal;

    public abstract class Procedure
    {
        private readonly List<Animal> procedureHistory;

        public Procedure()
        {
            this.procedureHistory = new List<Animal>();
        }

        public IReadOnlyCollection<Animal> ProcedureHistory => this.procedureHistory.AsReadOnly();

        public string History()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in ProcedureHistory)
            {
                sb.Append( $"{item.Name}"
                    + Environment.NewLine +
                    $"    - {item.GetType().Name} - Happiness: {item.Happiness} - Energy: {item.Energy}");

            }

            return sb.ToString().TrimEnd();
        }

        public virtual void DoService(Animal animal, int procedureTime)
        {
            if (animal.ProcedureTime >= procedureTime)
            {
                this.procedureHistory.Add(animal);
            }
            else
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }
        }
    }
}
