using System;

public class Program
{
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    };
    public Program() { }

    static void Main(string[] args)
    {
        Days today = Days.Sunday;
        switch (today)
        {
            case Days.Sunday: Console.WriteLine("Sunday");break;
            case Days.Monday: Console.WriteLine("Monday");break;
            case Days.Tuesday: Console.WriteLine("Tuesday");break;
            case Days.Wednesday:Console.WriteLine("Wednesday");break;
            case Days.Thursday: Console.WriteLine("Thursday");break;
            case Days.Friday:Console.WriteLine("Friday");break;
            case Days.Saturday: Console.WriteLine("Saturday");break;
            default: Console.WriteLine("Invalid");break;
        }
    }
}