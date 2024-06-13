using Microsoft.VisualBasic;
using System;

public class FeaturePhone : Mobile
{
	int buttonCount;
	public FeaturePhone(string brand, string model, int batteryLevel,int buttonCount) :base(brand,model,batteryLevel)
	{
		this.buttonCount = buttonCount;
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
        Console.WriteLine("Button Count: " + buttonCount);
    }
}
