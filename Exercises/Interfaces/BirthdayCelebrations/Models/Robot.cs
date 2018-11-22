using System;
using System.Collections.Generic;
using System.Text;

public class Robot : IIdentyfaible
{
    private string model;
    private string id;

    public Robot(string model, string id)
    {
       this.Id = id;
       this. Model = model;
    }

    public string Model
    {
        get => model;

        private set => model = value;
    }

    public string Id
    {
        get => id;

        private set => id = value;
    }

}

