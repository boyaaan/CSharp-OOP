using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{

    public static void Main()
    {
        List<Person> peopleCollection = new List<Person>();
        List<Products> productCollection = new List<Products>();

        try
        {
            string[] people = Console.ReadLine().Split("=;\\\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split("=;\\\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < people.Length; i += 2)
            {
                string name = people[i].Trim();
                decimal money = decimal.Parse(people[i + 1]);

                Person person = new Person(name, money);

                peopleCollection.Add(person);
            }


            for (int i = 0; i < products.Length; i += 2)
            {
                string name = products[i].Trim();
                decimal cost = decimal.Parse(products[i + 1]);

                Products product = new Products(name, cost);

                productCollection.Add(product);
            }

            string purchase = Console.ReadLine();

            while (purchase != "END")
            {
                string[] inputArguments = purchase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Person buyer = peopleCollection.FirstOrDefault(x => x.Name == inputArguments[0]);
                Products product = productCollection.FirstOrDefault(y => y.Name == inputArguments[1]);

                buyer.BuyProduct(product);

                purchase = Console.ReadLine();
            }

            foreach (var element in peopleCollection)
            {
                Console.WriteLine(element);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

