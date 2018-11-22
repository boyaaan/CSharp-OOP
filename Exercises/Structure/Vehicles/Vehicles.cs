using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicles : Products
{
    private int capacity;

    protected Vehicles(int capacity,decimal price, decimal weight) : base(price, weight)
    {
        this.Capacity = capacity;
    }

    public int Capacity { get; set; }
}

