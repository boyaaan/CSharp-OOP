using System;
using System.Collections.Generic;
using System.Text;

public class Child : Products
{
    private const decimal gpu = 0.7m;
    private const decimal hardDrive = 1.0m;
    private const decimal ram = 0.1m;
    private const decimal solidStateDrive = 0.2m;

    protected Child(decimal gpu, decimal hardDrive, decimal ram, decimal solidStateDrive, decimal price, decimal weight) : base(price, weight)
    {
        this.Gpu = gpu * price;
        this.HardDrive = hardDrive * price;
        this.Ram = ram * price;
        this.SolidStateDrive = solidStateDrive * price;
    }

    public decimal Gpu { get; set; }

    public decimal HardDrive { get; set; }

    public decimal Ram { get; set; }

    public decimal SolidStateDrive { get; set; }
}

