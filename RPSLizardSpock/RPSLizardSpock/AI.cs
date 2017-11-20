using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    public class AI:Player
    {
        public Random computerMove = new Random();
        public AI()
        {
            NameThePlayer(); 
        }
        public override void NameThePlayer()
        {
            playerName = "Hal9000";
        }
        public override int SelectYourMove()
        {
            
            playerMove = computerMove.Next(5);
            return playerMove;
        }
    }
}
