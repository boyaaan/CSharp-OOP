using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<string> bags;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Bags = new List<string>();
    }


    public string Name
    {
        get { return this.name; }
        set {

            if (string.IsNullOrWhiteSpace(value) || value == " ")
            {
                throw new ArgumentException("Name cannot be an empty string");
            }
            this.name = value;
        }
    }
    

    public decimal Money
    {
        get { return this.money; }
        set {

            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }  
    }
    
    public List<string> Bags
    {
        get { return this.bags; }
        set { this.bags = value; }
    }

    public void BuyProduct(Products product)
    {
        if (product.Cost > this.Money)
        {
            Console.WriteLine($"{this.Name} can't afford {product.Name}");
        }
        else
        {
            Console.WriteLine($"{this.Name} bought {product.Name}");

            this.Money -= product.Cost;
            this.Bags.Add(product.Name);
        }
    }

    public override string ToString()
    {
        string person = $"{this.Name} - ";

        if (this.Bags.Count == 0)
        {
            person += "Nothing bought";
        }
        else
        {
            person += string.Join(", ", this.Bags);
        }

        return person;
    }
}

