using System;



class Program
{
    public Program() { }

    static void Main(string[] args)
    {
        GCDemo<int> myInt = new GCDemo<int>(1,2);
        myInt.Add();
        GCDemo<string> myString = new GCDemo<string>("Hello"," World");
        myString.Add();
    }
}