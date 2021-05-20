using System;

namespace Mastermind
{
    class Game {
        private static Random random = new Random(); // it is used to pick a random letter

        // TO DO check the remaining lives!
        public static void GuessField (int lives, string word) // the box with the words suggestions
        {
            word = word.ToUpper();
            Console.WriteLine("Try to guess the word (" + word.Length + " letters)\n");
            for(int livesUsed=0; livesUsed<lives; livesUsed++)
            {
                string guessedWord = Console.ReadLine().ToUpper();
                if(guessedWord==word)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    string wonPrompt = @" __   __                                    
 \ \ / /___   _   _  __      __ ___   _ __  
  \ V // _ \ | | | | \ \ /\ / // _ \ | '_ \ 
   | || (_) || |_| |  \ V  V /| (_) || | | |
   |_| \___/  \__,_|   \_/\_/  \___/ |_| |_|
                                            ";
                    Console.WriteLine(wonPrompt);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress enter to go back");
                    return;
                }
                else
                {
                    for(int x=0; x<guessedWord.Length && x<word.Length; x++)
                    {
                        if(guessedWord[x]==word[x])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(guessedWord[x]);
                        }
                        else
                        {
                            if(word.Contains(guessedWord[x]))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(guessedWord[x]);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(guessedWord[x]);
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White; // reset the console color
                    }
                    if(lives-livesUsed > 1)
                    {
                        Console.WriteLine("\n\nRetry (" + (lives-livesUsed-1) + " lives left)\n");
                    }
                    else
                    {
                        Console.WriteLine("\n\nThe word was " + word + "\n");
                    }
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string prompt = @"   ____                                                  
  / ___|  __ _  _ __ ___    ___    ___ __   __ ___  _ __ 
 | |  _  / _` || '_ ` _ \  / _ \  / _ \\ \ / // _ \| '__|
 | |_| || (_| || | | | | ||  __/ | (_) |\ V /|  __/| |   
  \____| \__,_||_| |_| |_| \___|  \___/  \_/  \___||_|   
                                                         ";
            Console.WriteLine(prompt);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress enter to go back");
        }
    }
}