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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThe word was correct!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nGAME OVER");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}