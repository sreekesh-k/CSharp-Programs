using System;

public class Person
{
	public int id { get; private set; }
	private static int count = 1;
	public string name { get; set; }
	public int age { get; set; }
	public Person(string name, int age)
	{
		this.id = count;
		this.name = name;
		this.age = age;
		count++;
	}

	public void Display()
	{
		Console.WriteLine("===Details===");
		Console.WriteLine($"ID: {id}\nName: {name}\nAge: {age}");
	}
}
