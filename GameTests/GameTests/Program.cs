using System;
using System.Security.Cryptography.X509Certificates;


public class Program
{
    class Enemy
    {
        public int Level;
        public int Health;
        public int Damage;
        public int Defense;
        public int GP;
        public int XP;
        public int GroupAmount;
    }


    // Add dictionary with animal/races + their health + rnd number addition

    public static void Main(string[] args)
    {
        string name = "name";
        bool correct = false;
        string answer = "answer";
        int playerhealth = 100;
        int cathealth = 100;
        bool start = false;

        static void OffScreen()
        {
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);
            Console.WriteLine(" ");
            Thread.Sleep(100);

        }

        // Starting sumo cat

        Console.WriteLine("                                          \r\n            :\"-.          .-\";                   \r\n            |:`.`.__..__.'.';|                   \r\n            || :-\"      \"-; ||                   \r\n            :;              :;                   \r\n            /  .==.    .==.  \\                   \r\n           :      _.--._      ;                  Hello, traveller!\r\n           ; .--.' `--' `.--. :                  \r\n          :   __;`      ':__   ;                 \r\n          ;  '  '-._:;_.-'  '  :                 \r\n          '.       `--'       .'                 \r\n           .\"-._          _.-\".                  \r\n         .'     \"\"------\"\"     `.                \r\n        /`-                    -'\\               \r\n       /`-                      -'\\              \r\n      :`-   .'              `.   -';             \r\n      ;    /                  \\    :             \r\n     :    :                    ;    ;            \r\n     ;    ;                    :    :            \r\n     ':_:.'                    '.;_;'            \r\n        :_                      _;               \r\n        ; \"-._                -\" :`-.     _.._   \r\n        :_          ()          _;   \"--::__. `. \r\n         \\\"-                  -\"/`._           : \r\n        .-\"-.                 -\"-.  \"\"--..____.' \r\n       /         .__  __.         \\              \r\n      : / ,       / \"\" \\       . \\ ;        \r\n       \"-:___..--\"      \"--..___;-\"   ");
        Thread.Sleep(4000);
        OffScreen();
        Console.Clear();
        Console.WriteLine("                                          \r\n            :\"-.          .-\";                   \r\n            |:`.`.__..__.'.';|                   \r\n            || :-\"      \"-; ||                   \r\n            :;              :;                   \r\n            /  .==.    .==.  \\                   \r\n           :      _.--._      ;                  Shall we start?\r\n           ; .--.' `--' `.--. :                  \r\n          :   __;`      ':__   ;                 \r\n          ;  '  '-._:;_.-'  '  :                 \r\n          '.       `--'       .'                 \r\n           .\"-._          _.-\".                  \r\n         .'     \"\"------\"\"     `.                \r\n        /`-                    -'\\               \r\n       /`-                      -'\\              \r\n      :`-   .'              `.   -';             \r\n      ;    /                  \\    :             \r\n     :    :                    ;    ;            \r\n     ;    ;                    :    :            \r\n     ':_:.'                    '.;_;'            \r\n        :_                      _;               \r\n        ; \"-._                -\" :`-.     _.._   \r\n        :_          ()          _;   \"--::__. `. \r\n         \\\"-                  -\"/`._           : \r\n        .-\"-.                 -\"-.  \"\"--..____.' \r\n       /         .__  __.         \\              \r\n      : / ,       / \"\" \\       . \\ ;        \r\n       \"-:___..--\"      \"--..___;-\"   ");
        Console.WriteLine(" ");
        answer = Console.ReadLine().ToLower();
        start = answer.Contains("y");
        Console.Clear();
        if (start == false)
        {
            Console.WriteLine("                                          \r\n            :\"-.          .-\";                   \r\n            |:`.`.__..__.'.';|                   \r\n            || :-\"      \"-; ||                   \r\n            :;              :;                   \r\n            /  .==.    .==.  \\                   \r\n           :      _.--._      ;                  Oh, why not?\r\n           ; .--.' `--' `.--. :                  \r\n          :   __;`      ':__   ;                 \r\n          ;  '  '-._:;_.-'  '  :                 \r\n          '.       `--'       .'                 \r\n           .\"-._          _.-\".                  \r\n         .'     \"\"------\"\"     `.                \r\n        /`-                    -'\\               \r\n       /`-                      -'\\              \r\n      :`-   .'              `.   -';             \r\n      ;    /                  \\    :             \r\n     :    :                    ;    ;            \r\n     ;    ;                    :    :            \r\n     ':_:.'                    '.;_;'            \r\n        :_                      _;               \r\n        ; \"-._                -\" :`-.     _.._   \r\n        :_          ()          _;   \"--::__. `. \r\n         \\\"-                  -\"/`._           : \r\n        .-\"-.                 -\"-.  \"\"--..____.' \r\n       /         .__  __.         \\              \r\n      : / ,       / \"\" \\       . \\ ;        \r\n       \"-:___..--\"      \"--..___;-\"   ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("                                          \r\n            :\"-.          .-\";                   \r\n            |:`.`.__..__.'.';|                   \r\n            || :-\"      \"-; ||                   \r\n            :;              :;                   \r\n            /  .==.    .==.  \\                   \r\n           :      _.--._      ;                  Oh well! We're starting anyways, enjoy! :)\r\n           ; .--.' `--' `.--. :                  \r\n          :   __;`      ':__   ;                 \r\n          ;  '  '-._:;_.-'  '  :                 \r\n          '.       `--'       .'                 \r\n           .\"-._          _.-\".                  \r\n         .'     \"\"------\"\"     `.                \r\n        /`-                    -'\\               \r\n       /`-                      -'\\              \r\n      :`-   .'              `.   -';             \r\n      ;    /                  \\    :             \r\n     :    :                    ;    ;            \r\n     ;    ;                    :    :            \r\n     ':_:.'                    '.;_;'            \r\n        :_                      _;               \r\n        ; \"-._                -\" :`-.     _.._   \r\n        :_          ()          _;   \"--::__. `. \r\n         \\\"-                  -\"/`._           : \r\n        .-\"-.                 -\"-.  \"\"--..____.' \r\n       /         .__  __.         \\              \r\n      : / ,       / \"\" \\       . \\ ;        \r\n       \"-:___..--\"      \"--..___;-\"   ");
        }
        Thread.Sleep(2000);
        Console.Clear();


        // Name entry

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


        // Ask for tutorial

        Console.WriteLine($"Well then, {name}, welcome to my game.");
        Thread.Sleep(1000);
        Console.Write("It's a pleasure to have you here, ");
        Thread.Sleep(1000);
        Console.Write("do you know how to play this game? ");
        answer = Console.ReadLine().ToLower();
        correct = answer.Contains("y");
        Console.Clear();


        // No tutorial needed

        if (correct == true)
        {
            Console.WriteLine("Wow, that makes this easy.");
            Thread.Sleep(2000);
            Console.WriteLine("I'll just plop you right into gameplay then, enjoy!");
            Thread.Sleep(4000);
            Console.Clear();
            StartScreen();
        }

        // Tutorial needed

        else if (correct == false)
        {
            Console.WriteLine("Well then, I'll take you through the tutorial.");
            Thread.Sleep(2000);
            Tutorial();
        }


        // Tutorial

        static void Tutorial()
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
        

        // Start screen

        static void StartScreen()
        {
            Console.WriteLine("Welcome!!!!!!!!!!!!");
        }
    }
}