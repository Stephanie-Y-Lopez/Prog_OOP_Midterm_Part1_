using System;

public class Clothing : Product
{
    public string Size_ { get; set; }
    public string Color_ { get; set; }

    public Clothing(string name, double price, string Size, string Color) : base(name, price)
    {
        Size_ = Size;
        Color_ = Color;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Clothing: {Name}, Price: ${Price}, Size: {Size_}, Color: {Color_}");
    }
}
