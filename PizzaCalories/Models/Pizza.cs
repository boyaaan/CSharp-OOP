using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings;

    public Pizza(string name)
    {
        this.Name = name;
        this.Toppings = new List<Topping>();
    }

    public string Name
    {
        get => this.name;

        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException(ErrorMessages.PizzaInvalidName);
            }
            this.name = value;
        }
    }


    public Dough Dough
    {
        get { return this.dough; }
        set { this.dough = value; }
    }


    public List<Topping> Toppings
    {
        get => toppings;
        set => toppings = value;
    }

    public void Add(Topping topping)
    {
        if (this.toppings.Count >= 10)
        {
            throw new ArgumentException(ErrorMessages.PizzaInvalidToppingsCount);
        }
        toppings.Add(topping);
    }

    public double GetCalories()
    {
               
        double caloriesDough = this.Dough.DoughCalorie;
        double caloriesTopping = this.Toppings.Sum(x => x.ToppingCalory);

        return caloriesDough + caloriesTopping;
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.GetCalories():f2} Calories.";

    }
}

