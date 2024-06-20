using System;

public class objectsDemo
{
    public objectsDemo() { }

    public static void ObjectDemo()
    {
        try
        {
            string[] stringArray = new string[5];
            stringArray[0] = "Hello, World!";
            // Attempt to assign an integer to the string array
            // This will throw an ArrayTypeMismatchException
            object[] objectArray = stringArray;
            objectArray[1] = 42; // This is invalid and will cause an exception

            Console.WriteLine("No Error");
        }
        catch (ArrayTypeMismatchException ae)
        {
            Console.WriteLine("ArrayTypeMismatchException caught!");
            Console.WriteLine(ae.ToString());
        }
    }
}
