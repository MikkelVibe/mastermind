using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Words
    {
        public string[] normalOrd = new string[] // If the user has selected normal mode then these words will be used
        {
            "cool",
            "dsdaa",
            "dssada",
            "dsdaaa",

        };
        public string[] hardOrd = new string[]  // If the user has selected hard mode then these words will be used
        {
            "cooldsdasdaa",
            "dsdaadsdsadda",
            "dssadadasdadad",
            "dsdaaadasdasda",

        };
    }
}
