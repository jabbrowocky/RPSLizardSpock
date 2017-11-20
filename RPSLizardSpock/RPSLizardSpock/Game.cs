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
        public int playerOneMove;
        public int playerTwoMove;
        public string userWordOne;
        public string userWordTwo;
        public List<string> GameElements = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
       
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
            Console.WriteLine("'0' for Rock '1' for Paper '2' for Scissors '3' for Spock '4' for Lizard.\n\n");
            Console.Clear();
            while (!(FirstPlayer.playerWinTally == 2 || SecondPlayer.playerWinTally == 2))
            {
                DisplayKeys();
                PlayRound();
            }
            DisplayWinner();

        }
        public void DisplayKeys()
        {
            Console.WriteLine("'0' for Rock '1' for Paper '2' for Scissors '3' for Spock '4' for Lizard.\n\n");
        }
        public void PlayRound()
        {
            playerOneMove = FirstPlayer.SelectYourMove();
            playerTwoMove = SecondPlayer.SelectYourMove();
            GetUserInputWord();
            DisplayUserInputWords();
            CalculateRoundResults();
        }
        public void CalculateRoundResults()
        {
            int roundDeterminator = (5 + playerOneMove - playerTwoMove) % 5;
            if (roundDeterminator == 0)
            {
                DisplayRoundResult(FirstPlayer, SecondPlayer, true);
            }
            else if (roundDeterminator == 1 || roundDeterminator == 3)
            {
                DisplayRoundResult(FirstPlayer, SecondPlayer, false);
            }
            else if (roundDeterminator == 2 || roundDeterminator == 4)
            {
                DisplayRoundResult(SecondPlayer, FirstPlayer, false);
            }
        }
        
        public void DisplayWinner()
        {
            if (FirstPlayer.playerWinTally == 2)
            {
                Console.WriteLine("{0} has won the game", FirstPlayer.playerName);
                Console.ReadLine();
            }
            if (SecondPlayer.playerWinTally == 2)
            {
                Console.WriteLine("{0} has won the game", SecondPlayer.playerName);
                Console.ReadLine();
            }
        }
        public void DisplayRoundResult(Player winner, Player loser, bool isTie)
        {
            if (isTie == true)
            {
                Console.WriteLine("{0} has tied {1}\n\nPress any key to continue", winner.playerName, loser.playerName);
                DisplayScore(FirstPlayer, SecondPlayer);
                Console.ReadKey();

                Console.Clear();
            }
            else
            {
                Console.WriteLine("{0} has won the round.\n\nPress any key to continue.\n", winner.playerName);
                winner.playerWinTally++;
                DisplayScore(FirstPlayer, SecondPlayer);
                Console.ReadKey();
                Console.Clear();                
                
            }
        }

        public void DisplayScore(Player player1, Player player2)
        {
            Console.WriteLine(player1.playerName + " has a score of " + player1.playerWinTally + " and " + player2.playerName + " has a score of " + player2.playerWinTally);
        }
        public void GetUserInputWord()
        {
          
            userWordOne = GameElements[playerOneMove];
            userWordTwo = GameElements[playerTwoMove];
            
        }
        public void DisplayUserInputWords()
        {
            Console.WriteLine("\n{0} has selected {1}", FirstPlayer.playerName, userWordOne);
            Console.WriteLine("{0} has selected {1}\n", SecondPlayer.playerName, userWordTwo);
        }
        public void DisplayUserInputPhrase(Player winner, Player loser)
        {
            
        }
        public string DisplayInteraction(string winnerWord,string loserWord)
        {
            string losingTerm = "defeats";
            if ((winnerWord == "Scissors") && (loserWord == "Paper"))
            {
                losingTerm = "cuts";
            }
            else if ((winnerWord == "Paper") && (loserWord == "Rock"))
            {
                losingTerm = "covers";
            }
            else if ((winnerWord == "Rock") && (loserWord == "Lizard"))
            {
                losingTerm = "crushes";
            }
            else if ((winnerWord == "Lizard") && (loserWord == "Spock"))
            {
                losingTerm = "poisons";
            }
            else if ((winnerWord == "Spock") && (loserWord == "Scissors"))
            {
                losingTerm = "smashes";
            }
            else if ((winnerWord == "Scissors") && (loserWord == "Lizard"))
            {
                losingTerm = "decapitates";
            }
            else if ((winnerWord == "Lizard") && (loserWord == "Paper"))
            {
                losingTerm = "eats";
            }
            else if ((winnerWord == "Paper") && (loserWord == "Spock"))
            {
                losingTerm = "disproves";
            }
            else if ((winnerWord == "Spock") && (loserWord == "Rock"))
            {
                losingTerm = "vaporizes";
            }
            else if ((winnerWord == "Rock") && (loserWord == "Scissors"))
            {
                losingTerm = "blunts";
            }

            return losingTerm;
        }
       
    }
        
}
