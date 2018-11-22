using System;
using System.Collections.Generic;
using System.Text;

public class Dough
{
    private string flour;
    private string bakingTechnique;
    private double weight;

    public Dough(string flour, string bakingTechnique, double weight)
    {
        this.Flour = flour.ToLower();
        this.BakingTechnique = bakingTechnique.ToLower();
        this.Weight = weight;
        
    }

    public string Flour
    {
        get => flour;

        set
        {
            string curValue = value.ToLower();

            if (curValue != "white" &&
                curValue != "wholegrain")
            {
                throw new ArgumentException(ErrorMessages.DoughInvalidType);
            }
            flour = value;
        }
    }
    public string BakingTechnique
    {
        get => bakingTechnique;

        set
        {

            if (value != "crispy" &&
                value != "chewy" &&
                value != "homemade")
            {
                throw new ArgumentException(ErrorMessages.DoughInvalidType);
            }

            bakingTechnique = value;
        }
    }
    public double Weight
    {
        get => weight;

        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException(ErrorMessages.DoughInvalidWeight);
            }
            weight = value;
        }
    }

    public double DoughCalorie { get => CalculateDoughCalorie(); }

    private  double CalculateDoughCalorie()
    {
        double caloryesFlour = this.Flour == "white" ? 1.5 : 1.0;
        double caloriesBake = this.bakingTechnique == "crispy" ? 0.9 :
                              this.bakingTechnique == "chewy" ? 1.1 : 1.0;

        return (this.weight * 2) * caloriesBake * caloryesFlour;
    }
}

