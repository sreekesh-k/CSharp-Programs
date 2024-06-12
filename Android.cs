using System;

public class Android : Mobile, Icamera, Igps
{
    string osVersion;
    public Android(string brand, string model, string osVersion) : base(brand, model)
    {
        this.osVersion = osVersion;
    }
    public void TakePhoto()
    {
        Console.WriteLine("Nice Smile");
    }
    public void GetLocation()
    {

        Console.WriteLine("You are Currently at RCSS");
    }
    public void PrintPhoneDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Current Version: " + osVersion);
    }
}
