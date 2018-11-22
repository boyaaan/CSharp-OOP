using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthdate;
    private decimal food = 0;


    public Citizen(string name, int age, string id, string birthdate)
    {
        
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
        this.Food = food;
        this.Name = name;

    }

    public int Age
    {
        get => age;

        private set => age = value;
    }

    public string Id
    {
        get => id;

        private set => id = value;
    }

    public string Birthdate
    {
        get => birthdate;

        private set => birthdate = value;
    }
    
    public decimal Food
    {
        get => food;

        private set => food = value;
    }

    public string Name
    {
        get => name;

        private set => name = value;
    }

    public void BuyFood()
    {
        this.Food += 10;
    }
}

