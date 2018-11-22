using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal
{

    private string name;
    private string gender;
    private int age;

    protected Animal(string name, string gender, int age)
    {
        this.Name = name;
        this.Gender = gender;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }

        private set
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            name = value;
        }
    }


    public string Gender
    {
        get { return gender; }

        private set
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            gender = value;
        }
    }
    
    public int Age
    {
        get { return age; }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public virtual void ProduceSound()
    {
        Console.WriteLine("Screeeeeem");
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age} {this.Gender}";
    }
}

