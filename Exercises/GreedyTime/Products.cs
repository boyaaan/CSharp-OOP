using System;
using System.Collections.Generic;

public class Products
{
    private string name;
    private decimal cost;

    public Products(string name,decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }


    public string Name
    {
        get { return this.name; }
        set {

            if (string.IsNullOrWhiteSpace(value) || value == " ")
            {
                throw new ArgumentException("Name cannot be an empty string");
            }
            this.name = value; }
    }

    public decimal Cost
    {
        get { return this.cost; }
        set {

            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.cost = value; }
    }
}

