using System;

public class Android : Mobile
{
    string osVersion;
    public Android(string brand, string model, string osVersion) : base(brand, model)
    {
        this.osVersion = osVersion;
    }

    public void PrintPhoneDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Current Version: " + osVersion);
    }
}
