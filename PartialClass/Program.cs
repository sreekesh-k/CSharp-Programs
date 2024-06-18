using System;
public class Program
{
    public Program() { }


    static void Main(string[] args)
    {
        Book myBook = new Book();
        myBook.Printdetails();
        myBook.PrintPublisherDetails();
    }
}