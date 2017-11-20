using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    public class Game 
    {
        public bool playerOne;
        public bool playerTwo;
        public bool aiPlayer;
        public Game(bool playerOne, bool playerTwo, bool aiPlayer)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.aiPlayer = aiPlayer;
            GetPlayerTypes(GetNumberOfPlayers());
        }
        public string GetNumberOfPlayers()
        {
            string numberOfPlayers;
            Console.WriteLine("Let's decide how many players we want:");
            Console.WriteLine("For 1 player enter '1' or 2 players enter '2'?");
            numberOfPlayers = Console.ReadKey().KeyChar.ToString();
            return numberOfPlayers;

        }
        public void GetPlayerTypes(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                playerOne = true;
                aiPlayer = true;
                Human FirstPlayer = new Human();
                AI SecondPlayer = new AI();

            }
            else if (numberOfPlayers == "2")
            {
                playerOne = true;
                playerTwo = true;
                Human FirstPlayer = new Human();
                Human SecondPlayer = new Human();

            }else
            {
                Console.WriteLine("That is not a valid player input.");
                GetPlayerTypes(GetNumberOfPlayers());

            }
        }
        public void GetGameLogic()
        {

        }

    }
}
