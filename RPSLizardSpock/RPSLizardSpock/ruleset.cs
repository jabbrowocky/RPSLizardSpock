using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    public class ruleset
    {
        public bool playerOne;
        public bool playerTwo;
        public bool isAI;
        public ruleset(bool playerOne, bool playerTwo, bool isAI)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.isAI = isAI;
            DisplayRules();

        }
        public void DisplayRules()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("As made a thing by \"The Big Bang Theory\"\n");

            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("Ladies and gentleman, the rules are simple! Best of 3 rounds and...\n ------------------\n 1. Scissor cuts Paper.\n 2. Paper covers Rock.\n 3. Rock crushes Lizard\n 4. Lizard poisons Spock\n 5. Spock smashes Scissors\n 6. Scissors decapitates Lizard\n 7. Lizard eats Paper\n 8. Paper disproves Spock\n 9. Spock vaporizes Rock\n 10. (and as it always has) Rock crushes Paper.\n");
            Console.WriteLine("The game itself is easy enough, and is capable of hosting 1 player against an 'AI' player, or PvP (Player vs Player).");
            Console.WriteLine("So? shall we play? y or n?");
            Console.ReadKey();

        }
        public void GetPlayerType()
        {

        }
        public void GetPlayerInput()
        {

        }

    }
}
