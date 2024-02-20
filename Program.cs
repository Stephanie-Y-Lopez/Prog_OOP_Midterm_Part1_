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
            Clothing tShirt = new Clothing("T-shirt", 19.99, "Medium", "Red");
            tShirt.DisplayProductInfo();

            // Testing Electronics
            Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
            smartphone.DisplayProductInfo();

            // Testing Groceries
            Groceries banana = new Groceries("Banana", 0.99, "2024-02-10");
            banana.DisplayProductInfo();
            //(I hope you dont mind I switched up the order of the items for the price to be shown 2nd instead of last because it makes more sense to me since it is also the second isle shown in the table.)

        }
    }
}
