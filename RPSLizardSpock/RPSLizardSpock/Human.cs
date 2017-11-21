using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    public class Human:Player
    {
        
        public Human(string defaultHumanName)
        {
            this.defaultHumanName = defaultHumanName;
            NameThePlayer();
        }
        public override string SelectPlayerMove()
        {
            Console.WriteLine("{0} select your move.", playerName);
            playerMove = Console.ReadKey(true).KeyChar.ToString();
            if (!(playerMove == "0" || playerMove == "1" || playerMove == "2" || playerMove == "3" || playerMove == "4"))
            {
                
                SelectPlayerMove();
            }
            return playerMove;
        }
        
    }
}
