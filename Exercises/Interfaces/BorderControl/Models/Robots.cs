using System;
using System.Collections.Generic;
using System.Text;

public class Robots : IIdentyfaible
{
    private string model;
    private string id;

    public Robots(string model, string id)
    {
        this.Id = id;
        this.Model = model;
    }

    public string Id
    {
        get => id;

        private set => id = value;
    }

    public string Model
    {
        get => model;
        
        private set => model = value;
    }
}

