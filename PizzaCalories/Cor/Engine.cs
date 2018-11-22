using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    public void Run()
    {
        try
        {
            
            string nameOfPizza = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList()[1];
            Pizza pizza = new Pizza(nameOfPizza);

            var prodictsOfDough = Console.ReadLine()
               .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            string flour = prodictsOfDough[1];
            string beaking = prodictsOfDough[2];
            double weightOfDough = double.Parse(prodictsOfDough[3]);

            Dough dough = new Dough(flour, beaking, weightOfDough);
            pizza.Dough = dough; 

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            { 
                var curInput = input
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                
                string modifire = curInput[1];
                double weight = double.Parse(curInput[2]);

                Topping topping = new Topping(modifire, weight);
                pizza.Add(topping);

                double calorie = topping.ToppingCalory;
            }

           
            Console.WriteLine(pizza.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

