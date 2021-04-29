using System;



namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int difficult = 0;
            bool isInt = false;
            Console.Clear(); // grunden til jeg clear er fordi hvis brugeren går tilbage fra en af spillende skal hovedmenuen vere clear 
            while (!isInt)
            {
                Console.WriteLine("For fast walktrough press 1, Press 2 for to read the rules, Press 3 to begin playing Mastermind!, PRESS Q TO CLOSE PROGRAM");
                try
                {
                    int line;
                    line = int.Parse(Console.ReadLine());
                    if (line != 1 && line != 2 && line != 3)
                        break;
                    isInt = true;

                    switch (line)
                    {
                        case 0:
                            return;

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
                    Console.WriteLine("That's not 1, 2 or 3");
                    
                }
            }



            
            
        }
    }
}

