using System;



namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear(); // grunden til jeg clear er fordi hvis brugeren går tilbage fra en af spillende skal hovedmenuen vere clear 
            Console.WriteLine("For fast walktrough press 1, Press 2 for to read the rules, Press 3 to begin playing Mastermind!, PRESS Q TO CLOSE PROGRAM");

            string line = Console.ReadLine();
            if (int.TryParse(line, out var valg)) //Checker1111 om det er et heltal og hvis det er 1,2 eller 3
            {
                switch (valg)
                {
                    case 1:
                        Walktrough walktrough = new Walktrough(); //her refererer jeg til min klasse walktrough og navngiver den walktrough 
                        walktrough.Run(); // her siger jeg at hvis inputtet er 1 skal den åbne klassen walktrough
                        break;

                    case 2:
                        Rules rules = new Rules(); //her referer jeg til min klasse rules og navngiver den Rules
                        rules.Run(); // Her siger jeg at den skal starte Rules klassen 
                        break;

                    case 3:
                        Mastermind mastermind = new Mastermind(); //her referer jeg til min klasse mastermind og navngiver den Mastermind
                        mastermind.Run(); // Her siger jeg at den skal starte Rules klassen 
                        break;

                    default: // Hvis brugeren ikke har trykket hverken 1,2 eller 3 vil den bruge denne
                        Console.WriteLine($"You can only choose between 1, 2 og 3 OR PRESS Q TO CLOSE THE PROGRAM you have chossen: {valg}. press enter to continue."); //Her skriver jeg til brugeren at inputtet var forkert og hvad de har skrevet 

                        Console.ReadLine();
                        break; //her giver jeg brugeren mulighed for at læse hvad der er sket og hvordan de kan fortsætte  
                }
            }
            if (line.ToUpper() == "Q") return;

        }

    }
}

