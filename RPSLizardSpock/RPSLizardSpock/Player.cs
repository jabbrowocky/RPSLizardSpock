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
        public int playerMove;


        public Player()
        {

        }
        virtual public void NameThePlayer()
        {
            Console.WriteLine("{0} what is your name?\n", defaultHumanName);
            playerName = Console.ReadLine();
        }
        public abstract int SelectYourMove();
        

    }
}
