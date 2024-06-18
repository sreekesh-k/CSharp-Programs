using System;

public partial class Book
{

    public string autherName = "sreekesh";
    public int bookNumber = 110;

  
    public void Printdetails()
    {
        Console.WriteLine($"AutherName: {autherName}\nBookNumber: {bookNumber}");
    }
}
