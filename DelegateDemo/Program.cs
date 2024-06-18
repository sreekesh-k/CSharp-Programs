using System;

public class Program
{
    public Program() { }

    static void Main(string []args)
    {
        CalculateValue cv1 = new CalculateValue(MathOperaation.Sum);
        CalculateValue cv2 = new CalculateValue(MathOperaation.Sub);

        Console.WriteLine(cv1(100,200));
        Console.WriteLine(cv2(200,100));

        CalculateValue cv3 = cv1 + cv2;
        CalculateValue cv4 = cv3 - cv2;


        Console.WriteLine(cv3(100, 200));
        Console.WriteLine(cv4(100, 200));

    }
        
}
