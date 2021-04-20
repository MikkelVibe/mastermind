/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind
{
    class Game {
        private static Random random = new Random(); // it is used to pick a random letter
        static void Main(string[] args)
        {
            Box(10, "HELLO"); // generates a box with the random words
        }

        static void Box(int lives, string word) // the box with the words suggestions
        {
            static string GenerateChar (string chars) // to generate a random strig using the whole alphabet or just the given letters
            {
                if(chars=="") // definition of default characters
                {
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                }
                return(new string(Enumerable.Repeat(chars, 1).Select(s => s[random.Next(s.Length)]).ToArray())); // return of a string containing one random character
            }
            for(int x=0; x<lives; x++) // repeats until there are some lives
            {
                List<string> letters = new List<string>(); 
                int rightLetters = 0;
                while(letters.Count < 5) // fills 5 letters
                {
                    string temp = GenerateChar("");
                    if(word.Contains(temp)) // if the letter is correct increments counter
                    {
                        rightLetters++;
                    }
                    if(rightLetters==0 && letters.Count==4) // there is always a right letter
                    {
                        temp = GenerateChar(word);
                    }
                    letters.Add(temp); // the letter found is now added to the list
                }
                for(int c=0; c<5; c++)
                {
                    if(word.Contains(letters[c])) // a right letter is printed in red
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    System.Console.Write(letters[c]);
                    Console.ForegroundColor = ConsoleColor.White; // resets the standard color of the console
                }
                System.Console.WriteLine();
            }
        }
    }
}
*/