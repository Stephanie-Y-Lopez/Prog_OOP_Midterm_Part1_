using System;

public class Groceries : Product
{
    public string ExpiryDate { get; set; }

    public Groceries(string name, double price, string expiryDate) : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Grocery Item: {Name}, Price: ${Price}, Expiry Date: {ExpiryDate}");
    }
}
