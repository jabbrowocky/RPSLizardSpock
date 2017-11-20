using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    public class Human:Player
    {
        public int playerMove;
        public Human(string defaultHumanName)
        {
            this.defaultHumanName = defaultHumanName;
            NameThePlayer();
        }
        public override int SelectYourMove()
        {
            Console.WriteLine("{0} select your move.", playerName);
            playerMove = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            if (!(playerMove == 0 || playerMove == 1 || playerMove == 2 || playerMove == 3 || playerMove == 4))
            {
                Console.Clear();
                
                SelectYourMove();
            }
            return playerMove;
        }
        
    }
}
