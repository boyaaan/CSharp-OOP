using System;
using System.Collections.Generic;
using System.Text;

public class Topping
{
    private string modifire;
    private double weight;

    public Topping(string modifire, double weight)
    {
        this.Modifire = modifire.ToLower();
        this.Weight = weight;
    }

    public string Modifire
    {
        get => this.modifire;

        set
        {
            if (value != "meat" &&
                value != "veggies" &&
                value != "cheese" &&
                value != "sauce")
            {
                var curModifire = char.ToUpper(value[0]) + value.Substring(1);
                throw new ArgumentException(string.Format(ErrorMessages.ToppingInvalidType, curModifire));
            }
            this.modifire = value;
        }
    }

    public double Weight
    {
        get => this.weight;

        set
        {
            if (value < 1 || value > 50)
            {
                var curModifire = char.ToUpper(this.Modifire[0]) + this.Modifire.Substring(1);
                throw new ArgumentException(string.Format(ErrorMessages.ToppingInvalidWeight, curModifire));
            }
            this.weight = value;
        }
    }

    public double ToppingCalory { get => CalcolateToppingCalory(); }

    private double CalcolateToppingCalory()
    {
        double curTopic = this.Modifire == "meat" ? 1.2 :
                          this.Modifire == "veggies" ? 0.8 :
                          this.Modifire == "cheese" ? 1.1 : 0.9;

        return (weight * 2) * curTopic;
    }
}

