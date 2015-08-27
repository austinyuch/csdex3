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
        private static string winnable(int playerOne, int playerTwo)
        {
            if (playerOne - playerTwo == 1)
                return "Player one" + " advantage";
            if (playerOne == playerTwo)
                return "Deuce";
            return "Player one" + " win";
            //throw new NotImplementedException();
        }

        public static String score(int playerOne, int playerTwo)
        {   
            if (playerOne >= 4 || playerTwo >= 4)
            {
                return winnable(playerOne, playerTwo);
              
            }
            if (playerOne != playerTwo)
                return dictionary[playerOne] + " Love";
            return dictionary[playerOne] + " all";
        }

       
    }
}
