using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name;
        Console.WriteLine("Enter your name to start: ");
        name = Console.ReadLine();
        Console.Clear();
        Thread.Sleep(1000);
        Console.WriteLine("Welcome, " + name + " to my game.");
    }
}