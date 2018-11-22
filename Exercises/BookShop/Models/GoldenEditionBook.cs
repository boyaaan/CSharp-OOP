using System;
using System.Collections.Generic;
using System.Text;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string autor, string title, decimal price)
        : base(autor, title, price)
    {
    }

    protected override decimal Price
    {
        get
        {
            return base.Price * 1.3M;
        }
    }
}


