using System;
using System.Collections.Generic;

public static class MyDatabase
{
    private static List<string> data;

    static MyDatabase()
    {
        Console.WriteLine("The list is loading");
        data = new List<string>
        {
            "Data 1",
            "Data 2",
            "Data 3",
            "Data 4",
            "Data 5"
        };
    }

        public static List<string> Data // Static property
        {
            get { return data; }
        }
}

