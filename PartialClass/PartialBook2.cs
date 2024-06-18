using System;

public partial class Book
{
    string bookName="HelloWorld", publisherName="Sharon";
    public void PrintPublisherDetails()
    {
        Console.WriteLine($"BookName: {bookName}\nPublisherName: {publisherName}");
    }

}
