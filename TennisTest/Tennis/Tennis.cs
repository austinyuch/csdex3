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
        private static String[] dictionary = new String[] { "Love", "Fifteen", "Thirty","Forty"};

        public static String score(int playerOne, int playerTwo)
        {   
            if (playerOne ==1 && playerTwo == 0)
                return dictionary[playerOne] + " Love";           
            if (playerOne == 2 && playerTwo == 0)
                return dictionary[playerOne] + " Love";
            return dictionary[playerOne] + " all";
        }
    }
}
