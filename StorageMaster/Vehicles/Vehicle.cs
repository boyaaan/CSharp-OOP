using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Vehicles
{
    using Products;
    using StorageMaster.Factories;
    using System.Linq;

    public abstract class Vehicle
    {        
        private readonly List<Product> trunk;
        
        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new List<Product>();
        }

        public int Capacity { get; }

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        public bool IsFull => this.Trunk.Sum(x => x.Weight) >= Capacity;

        public bool IsEmpty => this.Trunk.Any();


        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            var product = this.trunk.Last();
            this.trunk.RemoveAt(this.trunk.Count - 1);

            return product;
        }

        public static implicit operator Vehicle(VahicleFactoty v)
        {
            throw new NotImplementedException();
        }
    }
}
