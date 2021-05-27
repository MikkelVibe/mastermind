using System;

namespace Mastermind
{
    class Game {
        public static void GuessField (int lives, string word) // den boks hvor man kan gætte ordet
        {
            word = word.ToUpper();
            Console.WriteLine("Try to guess the word (" + word.Length + " letters)\n");
            for(int livesUsed=0; livesUsed<lives; livesUsed++) // kører kun hvis der er liv tilbage
            {
                string guessedWord = Console.ReadLine().ToUpper();
                if(guessedWord==word) // hvis ordet er korrekt
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green; // teksten er grøn
                    string wonPrompt = @"    .-----.
   .' -   - '.
  /  .-. .-.  \
  |  | | | |  |     __   __
   \ \o/ \o/ /      \ \ / /___   _   _  __      __ ___   _ __
  _/    ^    \_      \ V // _ \ | | | | \ \ /\ / // _ \ | '_ \
 | \  '---'  / |      | || (_) || |_| |  \ V  V /| (_) || | | |
 / /`--. .--`\ \      |_| \___/  \__,_|   \_/\_/  \___/ |_| |_|
/ /'---` `---'\ \
'.__.       .__.'
    `|     |`
     |     \
     \      '--.
      '.        `\
        `'---.   |
           ,__) /
            `..'";
                    Console.WriteLine(wonPrompt);
                    Console.ForegroundColor = ConsoleColor.White; // teksten er hvid
                    Console.WriteLine("\nPress enter to go back");
                    return; // gå ud fra GuessField funktion
                }
                else // hvis ordet er ikke korrekt
                {
                    for(int x=0; x<guessedWord.Length && x<word.Length; x++) // kører for hvert bogstav i ordet (og det er aldrig ud af array)
                    {
                        if(guessedWord[x]==word[x]) // hvis bogstaven er korrekt i den korrekt position
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // teksten er grøn
                            Console.Write(guessedWord[x]); // skriver bogstaven
                        }
                        else // hvis bogstaven er ikke korrekt eller ikke i den korrekt position
                        {
                            if(word.Contains(guessedWord[x])) // hvis bogstaven er korrekt i den forkert position
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; // teksten er blå
                                Console.Write(guessedWord[x]); // skriver bogstaven
                            }
                            else // hvis bogstaven er helt forkert
                            {
                                Console.ForegroundColor = ConsoleColor.Red; // teksten er rød
                                Console.Write(guessedWord[x]); // skriver bogstaven
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White; // teksten er hvid igen
                    }
                    if(lives-livesUsed > 1) // hvis der er liv tilbage
                    {
                        Console.WriteLine("\n\nRetry (" + (lives-livesUsed-1) + " lives left)\n");
                    }
                }
            } // efter den kører kun hvis der er ikke liv tilbage
            Console.ForegroundColor = ConsoleColor.Red; // teksten er rød
            string prompt = @"    .-----.
   .' -   - '.
  /  .-. .-.  \
  |  | | | |  |       ____
   \ \o/ \o/ /       / ___|  __ _  _ __ ___    ___    ___ __   __ ___  _ __
  _/    ^    \_     | |  _  / _` || '_ ` _ \  / _ \  / _ \\ \ / // _ \| '__|
 | \   ---   / |    | |_| || (_| || | | | | ||  __/ | (_) |\ V /|  __/| |
 / /`--. .--`\ \     \____| \__,_||_| |_| |_| \___|  \___/  \_/  \___||_|
/ /'---` `---'\ \
'.__.       .__.'
    `|     |`       The word was " + word + @"
     |     \
     \      '--.
      '.        `\
        `'---.   |
           ,__) /
            `..'";
            Console.WriteLine(prompt);
            Console.ForegroundColor = ConsoleColor.White; // teksten er hvid
            Console.WriteLine("\nPress enter to go back");
        }
    }
}