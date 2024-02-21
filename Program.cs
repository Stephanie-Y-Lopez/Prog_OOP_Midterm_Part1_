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
            Console.WriteLine("Page 1 Work ^^");
            Console.WriteLine(" ");

            //Page 2: 
            // Creating a new instance of Groceries!
            Clothing Tshirt = new Clothing("T-shirt", 19.99, "Medium", "Red");
            //Tshirt.DisplayProductInfo();

            // Testing Electronics
            Electronics Smartphone = new Electronics("Smartphone", 799.99, "Apple");
            //Smartphone.DisplayProductInfo();

            // Testing Groceries
            Groceries Banana = new Groceries("Banana", 0.99, "2024-02-10");
            //Banana.DisplayProductInfo();
            //(I hope you dont mind I switched up the order of the items for the price to be shown 2nd instead of last because it makes more sense to me since it is also the second isle shown in the table.)

            //Creating the list
            //List<Product> productList = new List<Product>();
            //productList.Add(Tshirt);
            //productList.Add(Smartphone);
            //productList.Add(Banana);

            //foreach (Product product in productList)
            //{

            //   product.DisplayProductInfo();
            //}

            // Access the static property to get the data
            List<Product> products = MyDataBase2.Data;

            // Display the data from the static class
            foreach (Product product in products)
            {

                product.DisplayProductInfo();
            }
            Console.WriteLine("Page 2 Work ^^");
            Console.WriteLine(" ");

            //Page 4 and 5:
            Config.UpdateConnectionString("CramberryFarms", "main", "Admin", "1234");
            string connectionString = Config.ConnectionString;
            Database db = Database.ConnectToDatabase(connectionString);
            List<Product> data = db.Data();

            //Product testGetType = data[0];
            //Console.WriteLine(testGetType.GetType());
            //Type groceryType = typeof(Groceries);
            //bool sameType = testGetType.GetType() == groceryType;
            //// Printing the result!
            //Console.WriteLine($"Are they the same time: {sameType}");

            //foreach (Product d in data)
            //{
                //d.DisplayProductInfo();
            //}
            //Console.WriteLine("Page 4 Work ^^");
            Console.WriteLine(" ");

            // Menu -------------------------------------

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Display All Items");
                Console.WriteLine("2. Display Electronics");
                Console.WriteLine("3. Display Groceries");
                Console.WriteLine("4. Display Clothing");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayAllItems(data);
                        break;
                    case 2:
                        DisplayElectronics(data);
                        break;
                    case 3:
                        DisplayGroceries(data);
                        break;
                    case 4:
                        DisplayClothing(data);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void DisplayAllItems(List<Product> data)
        {
            foreach (Product product in data)
            {
                product.DisplayProductInfo();
            }
        }

        static void DisplayElectronics(List<Product> data)
        {
            foreach (Product product in data)
            {
                if (product.GetType() == typeof(Electronics))
                {
                    product.DisplayProductInfo();
                }
            }

        }

        static void DisplayGroceries(List<Product> data)
        {
            foreach (Product product in data)
            {
                if (product.GetType() == typeof(Groceries))
                {
                    product.DisplayProductInfo();
                }
            }
        }

        static void DisplayClothing(List<Product> data)
        {
            foreach (Product product in data)
            {
                if (product.GetType() == typeof(Clothing))
                {
                    product.DisplayProductInfo();
                }
            }
        }

    }
}
