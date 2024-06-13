using System;

public class Program
{
    public Program()
    {
    }
    static void Main(string[] args)
    {
        Android myMobile = new Android("IQoo", "Z9", "14o");
        myMobile.ChargeBattery(75);
        myMobile.MakeCall(100);
        myMobile.TakePhoto();
        myMobile.GetLocation();
        myMobile.PrintPhoneDetails();
    }
}