using System;
using System.Collections.Generic;
using System.Text;



namespace Mastermind
{
    

    class Mastermind
    {
        Random rng = new Random();
        public string ValgtOrd;
        new Words words = new Words();
        public bool mode;
        public void Run(int hardmode)
        {
            if (hardmode == 1) { mode = true; };  // Medium is selected
            if (hardmode == 2) { mode = false; };  // Hardmode is selected
            if (mode)
            {
                int random = rng.Next(0, words.normalOrd.Length);
                ValgtOrd = words.normalOrd[random];
                Console.Write(ValgtOrd);
            }
            else if (!mode)
            {
                int random = rng.Next(0, words.hardOrd.Length);
                ValgtOrd = words.hardOrd[random];
                Console.Write(ValgtOrd);
            }
            





            string line = Console.ReadLine();
            if (line.ToUpper() == "Q")
                return;

        }
    }
}