using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Rules
    {
        public void Run()
        {
            Console.Clear();

            string prompt = @"  ____          _            
 |  _ \  _   _ | |  ___  ___ 
 | |_) || | | || | / _ \/ __|
 |  _ < | |_| || ||  __/\__ \
 |_| \_\ \__,_||_| \___||___/
                             ";
            Console.Write(prompt);
            
            Console.WriteLine("\nBy reading these rules can you insure yourself the best player experience!");
            Console.WriteLine();
            Console.WriteLine("Rule nr. 1 You can only try guessing 12 times!");
            Console.WriteLine("Rule nr. 2 You can only try guessing on words depending on the level so if the level is medium you can guess on 3-6 letter words and when hard 7-10 letter words!");
            Console.WriteLine("Rule nr. 3 When you think you know the word, type it in the console and press enter!");
            Console.WriteLine("Rule nr. 4 If you guessed the letter/letters that aren't in the word it will mark the letter/letters with red.");
            Console.WriteLine("Rule nr. 5 If you guessed letter/letters that are in the word but not in the correct order it will mark the letter/letters with blue.");
            Console.WriteLine("Rule nr. 6 If you guessed letter/letters that are in the word and they are in the correct order it will mark the letter/letters with green.");

            Console.WriteLine("\nPress enter to go back");
            
            Console.Read();

        }
    }
}


