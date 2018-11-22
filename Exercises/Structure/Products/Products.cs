using System;
public abstract class Products
{
    private decimal price;
    private decimal weight;

    protected Products(decimal price, decimal weight)
    {
        this.Price = price;
        this.Weight = weight;
    }

    public decimal Price
    {
        get { return price; }
        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("error: Price cannot be negative!");
            }
            price = value; }
    }

    public decimal Weight
    {
        get { return weight; }
        private set { weight = value; }
    }

}

