using System;
using System.Collections.Generic;
using System.Text;
public class DataVehicles : Vehicles
{
    private readonly IList<Products> products;
    private bool isFull;

    public DataVehicles(List<Products> products,int capacity,bool isFull, decimal price, decimal weight) : base(capacity, price, weight)
    {
        this.IsFull = isFull;
         
    }

    public IList<Products> Product1
    {
        get
        {
            return this.products;
        }
    }

    public bool IsFull
    {
        get
        {
            return this.isFull;
        }
        set
        {
            if (Weight >= Capacity)
            {
                 this.isFull = true;
            }
            this.isFull = false;
        }
    }
}

