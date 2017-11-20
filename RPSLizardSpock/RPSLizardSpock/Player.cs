using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    public abstract class Player
    {
        public string defaultHumanName;
        public string playerName;
        public int playerChoice;
        public int playerWinTally = 0;


        public Player()
        {

        }
        virtual public void NameThePlayer()
        {
            Console.WriteLine("{0} what is your name?", defaultHumanName);
            playerName = Console.ReadLine();
        }
        public abstract int SelectYourMove();
        public void PlayerWins()
        {
            if (playerWinTally == 2)
            {
                Console.WriteLine("{0} wins", playerName);
            }

        }

    }
}
