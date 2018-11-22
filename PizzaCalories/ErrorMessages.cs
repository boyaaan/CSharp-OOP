using System;
using System.Collections.Generic;
using System.Text;

public class ErrorMessages
{
    public const string DoughInvalidWeight = "Dough weight should be in the range [1..200].";
    public const string DoughInvalidType = "Invalid type of dough.";

    public const string ToppingInvalidType = "Cannot place {0} on top of your pizza.";
    public const string ToppingInvalidWeight = "{0} weight should be in the range [1..50].";

    public const string PizzaInvalidName = "Pizza name should be between 1 and 15 symbols.";
    public const string PizzaInvalidToppingsCount = "Number of toppings should be in range [0..10].";

    public const string ModifierInvalid = "Such a modifier does not exist.";
}

