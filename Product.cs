using System;

public class Product
{
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void DisplayProductInfo()
        {
            Console.WriteLine("Product Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }
}
