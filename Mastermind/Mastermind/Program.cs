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

        static void ChooseDifficulty() // her laver jeg en funktion som jeg kalder "ChooseDifficulty" dette er så jeg kan refere til den senere i teksten 
        {
            bool isValid = false;
            Mastermind mastermind = new Mastermind(); // her referer jeg til min klasse mastermind og navngiver den Mastermind
            while (!isValid) //hvis brugeren har valgt at trykke 3 vil den udskrive "For medium press 1, for hardmode press 2"
            {
                Console.Clear();
                Console.WriteLine("For medium press 1, for hardmode press 2");

                string difficult = Console.ReadLine();
                Console.Clear();

                switch (difficult) //her lavet jeg en swich til mine 2 cases 
                {
                    case "1": // hvis 1 er valgt vil udkommet være korrekt og den vil derfor køre mastermind classen 1
                        isValid = true;
                        mastermind.Run(1);
                        break; // Jeg siger her at den skal stoppe med at læse koden og den vil derfor gå videre til mastermind clasen
                    case "2": // hvis 2 er valgt vil udkommet være korrekt og den vil derfor køre mastermind classen 2
                        isValid = true;
                        mastermind.Run(2);
                        break; // Jeg siger her at den skal stoppe med at læse koden og den vil derfor gå videre til mastermind classen
                }
            }
        }

        static bool PrintMenu()
        {
            bool isValid = false;
            Console.Clear(); // grunden til jeg clear er fordi hvis brugeren går tilbage fra en af spillende skal hovedmenuen vere clear 
            string prompt = @"  __  __              _                          _             _ 
 |  \/  |  __ _  ___ | |_  ___  _ __  _ __ ___  (_) _ __    __| |
 | |\/| | / _` |/ __|| __|/ _ \| '__|| '_ ` _ \ | || '_ \  / _` |
 | |  | || (_| |\__ \| |_|  __/| |   | | | | | || || | | || (_| |
 |_|  |_| \__,_||___/ \__|\___||_|   |_| |_| |_||_||_| |_| \__,_|
                                                                 ";
            Console.WriteLine(prompt);
            while (!isValid)
            {
                Console.WriteLine("Press 1 for a fast walktrough");
                Console.WriteLine("Press 2 for to read the rules");
                Console.WriteLine("Press 3 to begin playing Mastermind!");
                Console.WriteLine("Press Q to close the program");

                string line = Console.ReadLine().ToUpper();

                switch (line)
                {
                    case "Q":
                        return true;

                    case "1":
                        isValid = true;
                        Walkthrough walkthrough = new Walkthrough(); //her refererer jeg til min klasse walktrough og navngiver den walktrough 
                        walkthrough.Run(); // her siger jeg at hvis inputtet er 1 skal den åbne klassen walktrough
                        break;

                    case "2":
                        isValid = true;
                        Rules rules = new Rules(); //her referer jeg til min klasse rules og navngiver den Rules
                        rules.Run(); // Her siger jeg at den skal starte Rules klassen 
                        break;

                    case "3":
                        isValid = true;
                        ChooseDifficulty();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("That's not a valid command\n");
                        break;
                }
            }
            return false;
        }
    }
}

