using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public static class Config
    {
        public static string ConnectionString { get; private set; }

        //Updating Config Information!
        public static void UpdateConnectionString(string Server, string Database, string Username, string Password)
        {
            string driver = "Driver={SQL Server Native Client 11.0};";
            string serv = $"Server={Server};";
            string db = $"Database={Database};";
            string userId = $"Uid={Username};";
            string pass = $"Pwd={Password}";

            ConnectionString = $"{driver}{serv}{db}{userId}{pass}";
        }
    }
}
