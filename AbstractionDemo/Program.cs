using System;


public class Program
{
    public Program() { 
    
    }
    static void Main(string[] args)
    {
        Smartphone mySmartPhone = new Smartphone("IQoo","Z9",50,"14o");
        FeaturePhone myFeaturePhone = new FeaturePhone("Samsung", "Duos", 60, 30);

        mySmartPhone.StartDevice();
        myFeaturePhone.StartDevice();
        mySmartPhone.UseDevice();
        myFeaturePhone.UseDevice();

        mySmartPhone.ShowDetails();
        myFeaturePhone.ShowDetails();
    }
}