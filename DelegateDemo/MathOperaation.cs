using System;

delegate int CalculateValue(int x, int y);
public class MathOperaation
{
	public MathOperaation()
	{
	}

	public static int Sum(int a, int b)
	{
		return a + b;
	}
	public static int Sub(int a, int b)
	{
		return a - b;
	}

}
