using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Walkthrough
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(@"    .-----.
   .' -   - '.
  /  .-. .-.  \       __________________________________________________________
  |  | | | |  |     /                                                           \
   \ \o/ \o/ /     |  Hi, my name is Casper. I'm here to help you.               |
  _/    ^    \_    |  I will guide you through the logic of the game MasterMind.  |
 | \  '---'  / |   |  Press enter when you are ready...                          |
 / /`--. .--`\ \    \___________________________________________________________/
/ /'---` `---'\ \
'.__.       .__.'
    `|     |`
     |     \
     \      '--.
      '.        `\
        `'---.   |
           ,__) /
            `..'
");

            Console.Read();

            Console.Clear();
            Console.WriteLine(@"    .-----.
   .' -   - '.
  /  .-. .-.  \       __________________________________________________________
  |  | | | |  |     /                                                           \
   \ \o/ \o/ /     |  When you start the game you will get a small tip.          |
  _/    ^    \_    |  I will tell you how long the word you should guess is.     |
 | \  '---'  / |   |  Let's try to type MORE and let's see what happens!         |
 / /`--. .--`\ \    \___________________________________________________________/
/ /'---` `---'\ \
'.__.       .__.'
    `|     |`
     |     \          Try to guess the word (4 letters)
     \      '--.
      '.        `\    MORE
        `'---.   |
           ,__) /
            `..'
");

            Console.Read();

            Console.Clear();
            Console.Write(@"    .-----.
   .' -   - '.
  /  .-. .-.  \       __________________________________________________________
  |  | | | |  |     /                                                           \
   \ \o/ \o/ /     |  If the letter is green, it means that it is correct.       |
  _/    ^    \_    |  A blue one is contained in the word, but in wrong position.|
 | \  '---'  / |   |  A red one, instead, is wrong.                              |
 / /`--. .--`\ \    \___________________________________________________________/
/ /'---` `---'\ \
'.__.       .__.'
    `|     |`
     |     \          ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OR");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"
     \      '--.
      '.        `\    Retry (11 lives left)
        `'---.   |
           ,__) /
            `..'
");

            Console.Read();

            Console.Clear();
            Console.WriteLine(@"    .-----.
   .' -   - '.
  /  .-. .-.  \       __________________________________________________________
  |  | | | |  |     /                                                           \
   \ \o/ \o/ /     |  Now we have 11 lives left.                                 |
  _/    ^    \_    |  Since O and R were correct and there should be a M,        |
 | \  '---'  / |   |  let's try with WORM.                                       |
 / /`--. .--`\ \    \___________________________________________________________/
/ /'---` `---'\ \
'.__.       .__.'
    `|     |`
     |     \          Try to guess the word (4 letters)
     \      '--.
      '.        `\    WORM
        `'---.   |
           ,__) /
            `..'
");

            Console.Read();

            Console.Clear();
            Console.WriteLine(@"    .-----.
   .' -   - '.
  /  .-. .-.  \       __________________________________________________________
  |  | | | |  |     /                                                           \
   \ \o/ \o/ /     |  Congratulations! The word was correct!                     |
  _/    ^    \_    |  Now you are ready to start playing.                        |
 | \  '---'  / |   |  Remember that you can chose two difficulties and           |
 / /`--. .--`\ \   |  all your words are about distopia.                         |
/ /'---` `---'\ \  |  Press enter to go back to the main menu...                 |
'.__.       .__.'   \___________________________________________________________/
    `|     |`
     |     \
     \      '--.
      '.        `\
        `'---.   |
           ,__) /
            `..'
");

            Console.Read();

        }
    }

}