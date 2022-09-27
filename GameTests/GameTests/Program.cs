using System;
using System.Security.Cryptography.X509Certificates;

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
            Console.Write("Enter your name to start: ");
            name = Console.ReadLine();
            Console.Clear();
            Thread.Sleep(200);
            Console.Write($"{name}? Is that correct? ");
            answer = Console.ReadLine().ToLower();
            correct = answer.Contains("y");
            Console.Clear();
        }

        Console.WriteLine($"Well then, {name}, welcome to my game.");
        Thread.Sleep(1000);
        Console.Write("It's a pleasure to have you here, ");
        Thread.Sleep(1000);
        Console.Write("do you know how to play this game? ");
        answer = Console.ReadLine().ToLower();
        correct = answer.Contains("y");
        Console.Clear();


        if (correct == true)
        {
            Console.WriteLine("Wow, that makes this easy.");
            Thread.Sleep(2000);
            Console.WriteLine("I'll just plop you right into gameplay then, enjoy!");
            Thread.Sleep(4000);
            Console.Clear();
            StartScreen();
        }
        else if (correct == false)
        {
            Console.WriteLine("Well then, I'll take you through the tutorial.");
            Thread.Sleep(2000);
            Tutorial();
        }


        void Tutorial()
        {
            Console.Clear();
            Console.Write("So, you're new to the game, hm? ");
            Thread.Sleep(2000);
            Console.WriteLine("Don't worry though, I'll help you get on your feet:) !!");
            Thread.Sleep(2000);
            Console.WriteLine("The main idea of this game is to explore multiple different places such as cities, mountains etc..");
            Thread.Sleep(3000);
            Console.WriteLine("Along the way, you can tame and collect cats.");
            Thread.Sleep(2000);
            Console.WriteLine("However, there are some issues you come across, which will be revealed to you later on in the game.");
            Thread.Sleep(4000);
        }
        

        void StartScreen()
        {
            Console.WriteLine("Welcome!!!!!!!!!!!!");
        }
    }
}