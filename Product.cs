using System;

public abstract class Product
{
        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public abstract void DisplayProductInfo();
        //Removed method body
        //Declared as abstract
}
