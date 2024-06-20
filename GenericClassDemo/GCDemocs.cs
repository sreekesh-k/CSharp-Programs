using System;

public class GCDemo <T>
{
	T a, b;
	public GCDemo(T a, T b )
	{
		this.a = a;
		this.b = b;	
	}

	public void PrintType()
	{
		if (a != null && b != null) {
            Console.WriteLine($"Type of a: {a.GetType()}");
            Console.WriteLine($"Type of b: {b.GetType()}");
        }
    }
}
