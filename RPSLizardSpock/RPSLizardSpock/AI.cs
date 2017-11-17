using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    class AI:Player
    {
        public AI()
        {
            NameThePlayer(); 
        }
        public override void NameThePlayer()
        {
            playerName = "Hal9000";
        }
        public override void SelectYourMove()
        {

        }
    }
}
