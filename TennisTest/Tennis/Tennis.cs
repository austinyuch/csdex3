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
        private static String[] equalDict = new String[] { "Love", "Fifteen", "Thirty","Forty"};

        public static String score(int playerOne, int playerTwo)
        {

            if (playerOne == 1)
                return equalDict[1] + " all";
            if (playerOne == 2)
                return equalDict[2] + " all";
            if (playerOne == 3)          
                return equalDict[3] + " all";
            return "Love all";

        }
    }
}
