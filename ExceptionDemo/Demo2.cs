using System;

public class Class1
{
	public Class1()
	{
	}
	public void Test()
	{
		object []myObj = new object[2];
		myObj[0] = new object[1];
        ((object[])myObj[0])[0] = "HELLO"; 
        Console.WriteLine(((object[])myObj[0])[0]);
    }
}
