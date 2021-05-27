using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Rules
    {
        public void Run()
        {
            Console.Clear(); //Her clear jeg så vi har en ny console og spillet vil derfor se bedre ud.

            string prompt = // Jeg bruger string prompt for ikke at skulle lave consolewriteline til at skrive rules
                @"  ____          _            
 |  _ \  _   _ | |  ___  ___ 
 | |_) || | | || | / _ \/ __|
 |  _ < | |_| || ||  __/\__ \
 |_| \_\ \__,_||_| \___||___/


By reading these rules can you insure yourself the best player experience!

You can only try guessing 12 times!

You can only try guessing on words depending on the level so if the level is medium you can guess on 3-6 letter words and when hard 7-10 letter words!
                   
When you think you know the word, type it in the console and press enter!

If you guessed the letter/letters that aren't in the word it will mark the letter/letters with red.

If you guessed letter/letters that are in the word but not in the correct order it will mark the letter/letters with blue.

If you guessed letter/letters that are in the word and they are in the correct order it will mark the letter/letters with green.




Press enter to go back...
";
            Console.Write(prompt);            
            Console.ReadLine(); // Jég laver her en ReadLine for at give brugeren mullighed for at læse rules samt gøre sådan at de skal trykke enter for at komme tilbage til hovedmenuen

        }
    }
}


