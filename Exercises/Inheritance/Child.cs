using System;
using System.Collections.Generic;
using System.Text;

public class Child : Person
{
    public Child(string name, int age) : base(name, age)
    {
    }
      

    public override int Age
    {
        get
        {
            return base.Age;
        }

        protected set
        {
            string exepsins1 = value >= 15 ? throw new ArgumentException("Child's age must be less than 15!") : string.Empty;
            base.Age = value;
        }
    }


    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                             this.Name,
                             this.Age));

        return stringBuilder.ToString();
    }
}

