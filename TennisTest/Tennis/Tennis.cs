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
            if (playerOne >= 4 || playerTwo >= 4)
            {
                return winnable(playerOne, playerTwo, "Player one");              
            }
            if (playerOne != playerTwo)
                return dictionary[playerOne] + " Love";
            return dictionary[playerOne] + " all";
        }

        private static string winnable(int playerOne, int playerTwo, String winnerName)
        {
            if (playerOne < playerTwo)
                return winnable(playerTwo, playerOne, "Player two");
            if (playerOne - playerTwo == 1)
                //return winnerName + " advantage";
                return String.Format("{0} advantage", winnerName);
            if (playerOne == playerTwo)
                //return "Deuce";
                return String.Format("Deuce", winnerName);
            //return winnerName + " win";
            return String.Format("{0} win", winnerName);
            //throw new NotImplementedException();
        }
    }
}
