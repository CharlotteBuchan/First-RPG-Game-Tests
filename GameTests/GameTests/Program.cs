using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name = "name";
        bool correct = false;
        string answer = "answer";
        int playerhealth = 100;
        int cathealth = 100;



        while (correct == false)
        {
            Console.WriteLine("Enter your name to start: ");
            name = Console.ReadLine();
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine($"{name}? Is that correct?");
            answer = Console.ReadLine().ToLower();
            correct = answer.Contains("y");
            Console.Clear();
        }

        Console.WriteLine($"Well then, {name}, welcome to my game.");
        Thread.Sleep(1000);
        Console.WriteLine("It's a pleasure to have you here, do you know how to play this game?");
        answer = Console.ReadLine().ToLower();
        correct = answer.Contains("y");
        Console.Clear();


        if (correct == true)
        {
            Console.WriteLine("Wow, that makes this easy.");
            Thread.Sleep(2000);
            Console.WriteLine("I'll just plop you right into gameplay then, enjoy!");
            Thread.Sleep(5000);
            Console.Clear();
        }
        else if (correct == false)
        {
            Console.WriteLine("Well then, I'll take you through the tutorial.");
        }
    }
}