using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind
{
    class Game {
        private static Random random = new Random(); // it is used to pick a random letter

        // TO DO check the remaining lives!
        public static void GuessField (int lives, string word) // the box with the words suggestions
        {
            word = word.ToUpper();
            System.Console.WriteLine("\nTry to guess the word");
            while(true)
            {
                string guessedWord = System.Console.ReadLine().ToUpper();
                System.Console.WriteLine();
                if(guessedWord==word)
                {
                    System.Console.WriteLine("\nThe word was correct!");
                    break;
                }
                else
                {
                    for(int x=0; x<guessedWord.Length && x<word.Length; x++)
                    {
                        if(guessedWord[x]==word[x])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.Write(guessedWord[x]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            if(word.Contains(guessedWord[x]))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                System.Console.Write(guessedWord[x]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.Write(guessedWord[x]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    System.Console.WriteLine("\nRetry");
                }
            }
        }
    }
}