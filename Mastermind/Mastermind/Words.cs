using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Words
    {
        public string[] normalOrd = new string[] // If the user has selected normal mode then these words will be used
        {
            "wars",
            "robot",
            "end",
            "world",
            "utopia"
        };
        public string[] hardOrd = new string[]  // If the user has selected hard mode then these words will be used
        {
            "fiction",
            "politics",
            "scientist",
            "cyberpunk",
            "corruption"
        };
    }
}
