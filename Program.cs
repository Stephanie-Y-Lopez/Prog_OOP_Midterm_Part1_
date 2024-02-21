using System;
using System.Collections.Generic;

namespace Prog_OOP_Midterm_Part1
{
    internal class Program
    {
        // Stephanie Lopez!!
        static void Main()
        {
            //Page 1:
            List<string> dataList = MyDatabase.Data;

            // Display the data from the static class
            foreach (string item in dataList)
            {
                Console.WriteLine(item);
            }

            //Page 2: 
            // Creating a new instance of Groceries!
            //Clothing Tshirt = new Clothing("T-shirt", 19.99, "Medium", "Red");
            //Tshirt.DisplayProductInfo();

            // Testing Electronics
            //Electronics Smartphone = new Electronics("Smartphone", 799.99, "Apple");
            //Smartphone.DisplayProductInfo();

            // Testing Groceries
            //Groceries Banana = new Groceries("Banana", 0.99, "2024-02-10");
            //Banana.DisplayProductInfo();
            //(I hope you dont mind I switched up the order of the items for the price to be shown 2nd instead of last because it makes more sense to me since it is also the second isle shown in the table.)

            //Creating the list
            List<Product> productList = new List<Product>();
            productList.Add(Tshirt);
            productList.Add(Smartphone);
            productList.Add(Banana);

            foreach (Product product in productList)
            {

                product.DisplayProductInfo();
            }

            // Access the static property to get the data
            List<Product> dataList = MyDatabase.Data;

            // Display the data from the static class
            foreach (Product product in productList)
            {

                product.DisplayProductInfo();
            }
    }
}
