using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace GameTests
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
    public class Program
    {
        // Variables declaration

        static string Name = "name";
        static int PlayerHealth = 100;
        static int CatHealth = 100;
        static bool Start = false;
        static bool Correct = false;
        static string Answer = "answer";



        private static void Main(string[] args)
        {


            // Enemy types

            string[] EnemyTypes;

            // Dictionary

            var EnemyType = new Dictionary<int, string>();
            EnemyType.Add(1, "Dog");
            EnemyType.Add(2, "Squirrel");
            EnemyType.Add(3, "Hedgehog");
            EnemyType.Add(4, "Crow");
            EnemyType.Add(5, "Raccoon");
            EnemyType.Add(6, "Fox");
            EnemyType.Add(7, "Skunk");
            EnemyType.Add(8, "Coyote");
            EnemyType.Add(9, "Rat");
            EnemyType.Add(10, "Badger");
            EnemyType.Add(11, "Animal Control");


            Random RanNumber = new Random();
            int EnemyPick = RanNumber.Next(1, 11);
            Console.WriteLine(EnemyType.ElementAt(EnemyPick).Value);

            // Variables declaration

            string Name = "name";
            int PlayerHealth = 100;
            int CatHealth = 100;
            bool start = false;

            // Sumo cat
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

            // Enter name

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

        }


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


        // Start screen

        static void StartScreen()
        {
            TypeWriteLine("Welcome!!!!!!!!!!!!");
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
            Answer = Console.ReadLine().ToLower();
            Correct = Answer.Contains("y");
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
