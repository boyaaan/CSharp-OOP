using System;
using System.Collections.Generic;
using System.Text;


public class Book : ErrorExceptions
{
    private string autor;
    private string title;
    private decimal price;

    public Book(string autor, string title, decimal price)
    {
        this.Autor = autor;
        this.Title = title;
        this.Price = price;
    }
    
    private string Autor
    {
        get => this.autor;

        set
        {
            var indexOfSpace = value.IndexOf(' ');

            if (indexOfSpace > 0 && indexOfSpace < value.Length - 1 && char.IsDigit(value[indexOfSpace + 1]))
            {
                throw AutorExseption;
            }
            this.autor = value;
        }
    }

    private string Title
    {
        get
        {
            return this.title;
        }

        set
        {
            if (value.Length < 3)
            {
                throw TitleExseption;
            }

            this.title = value;
        }
    }

    protected virtual decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value <= 0)
            {
                throw PriceExseption;
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Autor}")
            .AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }

}

