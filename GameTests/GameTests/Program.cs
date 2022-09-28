using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


public class Program
{

    // Enemy class variables
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

    // Player class variables
    class Player
    {
        public int Level;
        public int Health;
        public int Damage;
        public int Defense;
        public int GP;
        public int XP;
    }


    // Add dictionary with animal/races + their health + rnd number addition


    public static void Main(string[] args, Random random)
    {

        // Enemy types

        string[] EnemyTypes;

        // Dictionary

        {
            Dictionary<string, int> EnemyType = new Dictionary<string, int>();
            EnemyType.Add("Dog", 1);
            EnemyType.Add("Squirrel",2);
            EnemyType.Add("Hedgehog",3);
            EnemyType.Add("Crow",4);
            EnemyType.Add("Raccoon",5);
            EnemyType.Add("Fox",6);
            EnemyType.Add("Skunk",7);
            EnemyType.Add("Coyote",8);
            EnemyType.Add("Rat",9);
            EnemyType.Add("Badger",10);
            EnemyType.Add("Animal Control",11);
        }

        int EnemyPick = random.Next(1, 11);
        Console.WriteLine(EnemyPick);

        // Variables declaration

        string Name = "name";
        bool Correct = false;
        string Answer = "answer";
        int PlayerHealth = 100;
        int CatHealth = 100;
        bool start = false;


        //Scroll off-screen

        static void OffScreen()
        {
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);
            Console.WriteLine(" ");
            Thread.Sleep(25);

        }


        // Starting sumo cat

        {
            Console.WriteLine("                                          \r\n            :\"-.          .-\";                   \r\n            |:`.`.__..__.'.';|                   \r\n            || :-\"      \"-; ||                   \r\n            :;              :;                   \r\n            /  .==.    .==.  \\                   \r\n           :      _.--._      ;                  Hello, traveller!\r\n           ; .--.' `--' `.--. :                  \r\n          :   __;`      ':__   ;                 \r\n          ;  '  '-._:;_.-'  '  :                 \r\n          '.       `--'       .'                 \r\n           .\"-._          _.-\".                  \r\n         .'     \"\"------\"\"     `.                \r\n        /`-                    -'\\               \r\n       /`-                      -'\\              \r\n      :`-   .'              `.   -';             \r\n      ;    /                  \\    :             \r\n     :    :                    ;    ;            \r\n     ;    ;                    :    :            \r\n     ':_:.'                    '.;_;'            \r\n        :_                      _;               \r\n        ; \"-._                -\" :`-.     _.._   \r\n        :_          ()          _;   \"--::__. `. \r\n         \\\"-                  -\"/`._           : \r\n        .-\"-.                 -\"-.  \"\"--..____.' \r\n       /         .__  __.         \\              \r\n      : / ,       / \"\" \\       . \\ ;        \r\n       \"-:___..--\"      \"--..___;-\"   ");
            Thread.Sleep(300);
            Console.WriteLine(" ");
            TypeWrite("Say hi back! ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("                                          \r\n            :\"-.          .-\";                   \r\n            |:`.`.__..__.'.';|                   \r\n            || :-\"      \"-; ||                   \r\n            :;              :;                   \r\n            /  .==.    .==.  \\                   \r\n           :      _.--._      ;                  Shall we start?\r\n           ; .--.' `--' `.--. :                  \r\n          :   __;`      ':__   ;                 \r\n          ;  '  '-._:;_.-'  '  :                 \r\n          '.       `--'       .'                 \r\n           .\"-._          _.-\".                  \r\n         .'     \"\"------\"\"     `.                \r\n        /`-                    -'\\               \r\n       /`-                      -'\\              \r\n      :`-   .'              `.   -';             \r\n      ;    /                  \\    :             \r\n     :    :                    ;    ;            \r\n     ;    ;                    :    :            \r\n     ':_:.'                    '.;_;'            \r\n        :_                      _;               \r\n        ; \"-._                -\" :`-.     _.._   \r\n        :_          ()          _;   \"--::__. `. \r\n         \\\"-                  -\"/`._           : \r\n        .-\"-.                 -\"-.  \"\"--..____.' \r\n       /         .__  __.         \\              \r\n      : / ,       / \"\" \\       . \\ ;        \r\n       \"-:___..--\"      \"--..___;-\"   ");
            Console.WriteLine(" ");
            Thread.Sleep(300);
            TypeWrite("Answer: ");
            Answer = Console.ReadLine().ToLower();
            start = Answer.Contains("y");
            if (start == false)
            {
                Console.WriteLine("                                          \r\n            :\"-.          .-\";                   \r\n            |:`.`.__..__.'.';|                   \r\n            || :-\"      \"-; ||                   \r\n            :;              :;                   \r\n            /  .==.    .==.  \\                   \r\n           :      _.--._      ;                  Oh, why not?\r\n           ; .--.' `--' `.--. :                  \r\n          :   __;`      ':__   ;                 \r\n          ;  '  '-._:;_.-'  '  :                 \r\n          '.       `--'       .'                 \r\n           .\"-._          _.-\".                  \r\n         .'     \"\"------\"\"     `.                \r\n        /`-                    -'\\               \r\n       /`-                      -'\\              \r\n      :`-   .'              `.   -';             \r\n      ;    /                  \\    :             \r\n     :    :                    ;    ;            \r\n     ;    ;                    :    :            \r\n     ':_:.'                    '.;_;'            \r\n        :_                      _;               \r\n        ; \"-._                -\" :`-.     _.._   \r\n        :_          ()          _;   \"--::__. `. \r\n         \\\"-                  -\"/`._           : \r\n        .-\"-.                 -\"-.  \"\"--..____.' \r\n       /         .__  __.         \\              \r\n      : / ,       / \"\" \\       . \\ ;        \r\n       \"-:___..--\"      \"--..___;-\"   ");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("                                          \r\n            :\"-.          .-\";                   \r\n            |:`.`.__..__.'.';|                   \r\n            || :-\"      \"-; ||                   \r\n            :;              :;                   \r\n            /  .==.    .==.  \\                   \r\n           :      _.--._      ;                  Oh well! We're starting anyways, enjoy! :)\r\n           ; .--.' `--' `.--. :                  \r\n          :   __;`      ':__   ;                 \r\n          ;  '  '-._:;_.-'  '  :                 \r\n          '.       `--'       .'                 \r\n           .\"-._          _.-\".                  \r\n         .'     \"\"------\"\"     `.                \r\n        /`-                    -'\\               \r\n       /`-                      -'\\              \r\n      :`-   .'              `.   -';             \r\n      ;    /                  \\    :             \r\n     :    :                    ;    ;            \r\n     ;    ;                    :    :            \r\n     ':_:.'                    '.;_;'            \r\n        :_                      _;               \r\n        ; \"-._                -\" :`-.     _.._   \r\n        :_          ()          _;   \"--::__. `. \r\n         \\\"-                  -\"/`._           : \r\n        .-\"-.                 -\"-.  \"\"--..____.' \r\n       /         .__  __.         \\              \r\n      : / ,       / \"\" \\       . \\ ;        \r\n       \"-:___..--\"      \"--..___;-\"   ");
            }
            Thread.Sleep(2000);
            OffScreen();
            Console.Clear();
        }


        // Name entry

        {
            while (Correct == false)
            {
                TypeWrite("Enter your name to start: ");
                Name = Console.ReadLine();
                Console.Clear();
                Name = char.ToUpper(Name[0]) + Name[1..];
                Thread.Sleep(200);
                TypeWrite($"{Name}? Is that correct? ");
                Answer = Console.ReadLine().ToLower();
                Correct = Answer.Contains("y");
                Console.Clear();
            }
        }


        // Ask for tutorial

        {
            TypeWriteLine($"Well then, {Name}, welcome to my game.");
            Thread.Sleep(1000);
            TypeWrite("It's a pleasure to have you here, ");
            Thread.Sleep(1000);
            TypeWrite("do you know how to play this game? ");
            Answer = Console.ReadLine().ToLower();
            Correct = Answer.Contains("y");
            Console.Clear();
        }


        // Tutorial Answers

        {

            // No tutorial needed

            if (Correct == true)
            {
                TypeWriteLine("Wow, that makes this easy.");
                Thread.Sleep(2000);
                TypeWriteLine("I'll just plop you right into gameplay then, enjoy!");
                Thread.Sleep(4000);
                Console.Clear();
                StartScreen();
            }

            // Tutorial needed

            else if (Correct == false)
            {
                TypeWriteLine("Well then, I'll take you through the tutorial.");
                Thread.Sleep(1000);
                Tutorial();
            }
        }


        // Tutorial

        static void Tutorial()
        {
            Console.Clear();
            TypeWrite("So, you're new to the game, hm? ");
            Thread.Sleep(1000);
            TypeWriteLine("Don't worry though, I'll help you get on your feet :) !!");
            Thread.Sleep(2000);
            TypeWriteLine("The main idea of this game is to explore multiple different places such as cities, mountains etc..");
            Thread.Sleep(2000);
            TypeWriteLine("Along the way, you can tame and collect cats.");
            Thread.Sleep(2000);
            TypeWriteLine("However, there are some issues you will face, which will be revealed to you later on in the game.");
            Thread.Sleep(2500);
            Console.Clear();
            TypeWrite("Would you like to play a test fight scene? ");
        }


        // Start screen

        static void StartScreen()
        {
            TypeWriteLine("Welcome!!!!!!!!!!!!");
        }






        // Scrolly text function WriteLine

        static void TypeWriteLine(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(40);
            }
            Thread.Sleep(100);
            Console.WriteLine("");


        }

        // Scrolly text function Write

        static void TypeWrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(40);
            }
            Thread.Sleep(100);
            Console.Write("");
        }
    }
}
