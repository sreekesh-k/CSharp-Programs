using System;

public abstract class Mobile
{
	protected string brand, model;
	protected int batteryLevel;
	public Mobile(string brand, string model, int batteryLevel)
	{
		this.brand = brand;
		this.model = model;	
		this.batteryLevel = batteryLevel;
	}

	public abstract void StartDevice();
	public abstract void UseDevice();
	public void ShowDetails()
	{
		Console.WriteLine("===Details===");
		Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("BatteryLevel: " + batteryLevel);
    }
}
