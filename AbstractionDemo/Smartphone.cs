using System;

public class Smartphone:Mobile
{
    string osVersion;
    public Smartphone(string brand, string model, int batteryLevel, string osVersion) : base(brand, model, batteryLevel)
    {
        this.osVersion = osVersion;
    }
    override public void StartDevice()
    {
        Console.WriteLine($"{brand} Started..");
    }
    override public void UseDevice()
    {
        Console.WriteLine($"{brand} In Use..");
    }
    public void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("OS Version: " + osVersion);
    }
}
