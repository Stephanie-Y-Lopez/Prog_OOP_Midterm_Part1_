using System;
using System.Collections.Generic;

public static class MyDatabase
{
    private static List<Product> data;

    static MyDatabase()
    {
        Console.WriteLine("The list is loading");
        Clothing tShirt = new Clothing("T-shirt", 19.99, "Medium", "Red");
        Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
        Groceries banana = new Groceries("Banana", 0.99, "2024-02-10");

        data = new List<Product>();

        data.Add(tshirt);
        data.Add(smartphone);
        data.Add(banana);
    }
        public static List<Product> Data
        {
            get { return data; }
        }
}
