using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TennisScore;

namespace TennisScore
{
    public class Tennis
    {
        public static String score(int playerOne, int playerTwo)
        {
            if (playerOne == 0)
                return "Love all";
            if (playerOne == 1)
                return "Fifteen all";
            if (playerOne == 2)          
                return "Thirty all";
            return "Forty all";

        }
    }
}
