using System;
using System.Collections.Generic;

namespace Prog_OOP_Midterm_Part1
{
    internal class Program
    {
        // Stephanie Lopez!!
        static void Main()
        {
            List<string> dataList = MyDatabase.Data;

            // Display the data from the static class
            foreach (string item in dataList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
