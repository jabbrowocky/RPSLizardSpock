﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    abstract class Player
    {
        public string playerName;
        public int playerChoice;
        public int PlayerWinTally;


        public Player()
        {

        }
        virtual public void NameThePlayer()
        {
            Console.WriteLine("What is the name of your player?");
            playerName = Console.ReadLine();
        }
        public abstract void SelectYourMove();
        public void PlayerWins()
        {
            if (PlayerWinTally == 2)
            {
                Console.WriteLine("{0} wins", playerName);
            }

        }

    }
}