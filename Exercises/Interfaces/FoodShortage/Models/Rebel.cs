using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : IBuyer
{
    private string name;
    private int age;
    private string group;
    private decimal food = 0;

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
        this.Food = food;
    }

    public string Name
    {
        get => name;

        private set => name = value;
    }

    public int Age
    {
        get => age;

        private set => age = value;
    }

    public string Group
    {
        get => group;

        private set => group = value;
    }

    public decimal Food
    {
        get => food;

        set => food = value;
    }

    public void BuyFood()
    {
        this.food += 5;
    }
}

