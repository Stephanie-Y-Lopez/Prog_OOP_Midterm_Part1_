using System;

public class Electronics : Product
{
    public string Brand_ { get; set; }

    public Electronics(string name, double price, string Brand) : base(name, price)
    {
        Brand_ = Brand;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Electronic: {Name},  Price: ${Price}, Brand: {Brand_}");
    }
}
