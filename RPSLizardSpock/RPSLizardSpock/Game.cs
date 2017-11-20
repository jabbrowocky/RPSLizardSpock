using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLizardSpock
{
    public class Game 
    {
        public Player FirstPlayer;
        public Player SecondPlayer;
       
        public Game()
        {
           
            GetPlayerTypes(GetNumberOfPlayers());
        }
        public string GetNumberOfPlayers()
        {
            string numberOfPlayers;
            Console.WriteLine("Let's decide how many players we want:\n");
            Console.WriteLine("For 1 player enter '1' or for 2 players enter '2'?\n");
            numberOfPlayers = Console.ReadKey(true).KeyChar.ToString();
            return numberOfPlayers;

        }
        public void GetPlayerTypes(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                FirstPlayer = new Human("Player 1");
                SecondPlayer = new AI();
                Console.Clear();
                PlayGame();

            }
            else if (numberOfPlayers == "2")
            {
                FirstPlayer = new Human("Player 1");
                SecondPlayer = new Human("Player 2");
                Console.Clear();
                PlayGame();

            }else
            {
              
                GetPlayerTypes(GetNumberOfPlayers());

            }
        }
        public void PlayGame()
        {
            Console.WriteLine("Alright, let's start the game hombres!\n\n Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("'0' for Rock '1' for Paper '2' for Scissors '3' for Spock '4' for Lizard.\n");
            Console.Clear();
            DisplayKeys();
            PlayRound();

        }
        public void DisplayKeys()
        {
            Console.WriteLine("'0' for Rock '1' for Paper '2' for Scissors '3' for Lizard '4' for Spock.\n");
        }
        public void PlayRound()
        {
            FirstPlayer.SelectYourMove();
            SecondPlayer.SelectYourMove();
        }

    }
        
}
