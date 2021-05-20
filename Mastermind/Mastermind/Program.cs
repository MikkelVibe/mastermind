using System;



namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldStop = false;
            while(!shouldStop)
            {
                shouldStop = PrintMenu();
            }
        }

        static bool PrintMenu()
        {
            int difficult = 0;
            bool isInt = false;
            Console.Clear(); // grunden til jeg clear er fordi hvis brugeren går tilbage fra en af spillende skal hovedmenuen vere clear 
            string prompt = @"  __  __              _                          _             _ 
 |  \/  |  __ _  ___ | |_  ___  _ __  _ __ ___  (_) _ __    __| |
 | |\/| | / _` |/ __|| __|/ _ \| '__|| '_ ` _ \ | || '_ \  / _` |
 | |  | || (_| |\__ \| |_|  __/| |   | | | | | || || | | || (_| |
 |_|  |_| \__,_||___/ \__|\___||_|   |_| |_| |_||_||_| |_| \__,_|
                                                                 ";
            Console.WriteLine(prompt);
            while (!isInt)
            {
                Console.WriteLine("Press 1 for a fast walktrough");
                Console.WriteLine("Press 2 for to read the rules");
                Console.WriteLine("Press 3 to begin playing Mastermind!");
                Console.WriteLine("Press 0 to close the program");
                try
                {
                    int line;
                    line = int.Parse(Console.ReadLine());
                    if (line != 0 && line != 1 && line != 2 && line != 3)
                        break;
                    isInt = true;

                    switch (line)
                    {
                        case 0:
                            return true;

                        case 1:
                            Walktrough walktrough = new Walktrough(); //her refererer jeg til min klasse walktrough og navngiver den walktrough 
                            walktrough.Run(); // her siger jeg at hvis inputtet er 1 skal den åbne klassen walktrough
                            break;

                        case 2:
                            Rules rules = new Rules(); //her referer jeg til min klasse rules og navngiver den Rules
                            rules.Run(); // Her siger jeg at den skal starte Rules klassen 
                            break;

                        case 3:
                            bool issInt = false;
                            Mastermind mastermind = new Mastermind(); //her referer jeg til min klasse mastermind og navngiver den Mastermind
                            while (!issInt)
                            {

                                Console.WriteLine("For medium press 1, for hardmode press 2");
                                try
                                {
                                    difficult = int.Parse(Console.ReadLine());
                                    if (difficult != 1 && difficult != 2)
                                        break;
                                    issInt = true;
                                    Console.Clear();
                                }
                                catch
                                {
                                    Console.Clear();
                                }
                            }
                            mastermind.Run(difficult);
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("That's not a valid number");
                }
            }
            return false;
        }
    }
}

