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
        public string playerOneMove;
        public int playerOneInput;
        public string playerTwoMove;
        public int playerTwoInput;
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
            Console.WriteLine("\nLet's decide how many players we want:\n");
            Console.Write("For 1 player mode enter ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("1");
            Console.ResetColor();
            Console.Write(" or for 2 players enter ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("2.\n");
            Console.ResetColor();
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
            for (int i = 0; i < GameElements.Count(); i ++ )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(i);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" for " + GameElements[i] + " ");
                Console.ResetColor();
            }
            Console.WriteLine("\n\n");
                        
        }
        public void PlayRound()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            playerOneMove = FirstPlayer.SelectPlayerMove();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            playerTwoMove = SecondPlayer.SelectPlayerMove();
            Console.ResetColor();
            DisplayUserInputWords();
            CalculateRoundResults();
        }
        public void CalculateRoundResults()
        {
            int roundDeterminator = (5 + playerOneInput - playerTwoInput) % 5;
            if (roundDeterminator == 0)
            {
                DisplayRoundResult(FirstPlayer, SecondPlayer, true);
            }
            else if (roundDeterminator == 1 || roundDeterminator == 3)
            {
              

                DisplayUserInputPhrase(userWordOne, userWordTwo);
                DisplayRoundResult(FirstPlayer, SecondPlayer, false);
            }
            else if (roundDeterminator == 2 || roundDeterminator == 4)
            {
               
                DisplayUserInputPhrase(userWordTwo, userWordOne);
                DisplayRoundResult(SecondPlayer, FirstPlayer, false);
            }
        }
        
        public void DisplayWinner()
        {
            if (FirstPlayer.playerWinTally == 2)
            {
                Console.WriteLine("{0} has won the game", FirstPlayer.playerName);
                Console.ReadLine();
                ResetOption();
            }
            if (SecondPlayer.playerWinTally == 2)
            {
                Console.WriteLine("{0} has won the game", SecondPlayer.playerName);
                Console.ReadLine();
                ResetOption();
            }
        }
        public void DisplayRoundResult(Player winner, Player loser, bool isTie)
        {
            if (isTie == true)
            {

                Console.WriteLine("\n{0} has tied {1}\n.", winner.playerName, loser.playerName);
                DisplayScore(FirstPlayer, SecondPlayer);
                Console.ReadKey();

                Console.Clear();
            }
            else
            {
                Console.WriteLine("{0} has won the round.\n", winner.playerName);
                winner.playerWinTally++;
                DisplayScore(FirstPlayer, SecondPlayer);
                Console.ReadKey();
                Console.Clear();                
                
            }
        }

        public void DisplayScore(Player player1, Player player2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player1.playerName + " has a score of " + player1.playerWinTally + " and " + player2.playerName + " has a score of " + player2.playerWinTally);
            Console.ResetColor();
            Console.WriteLine("\n\nPress any key to continue.\n");
        }
        public void GetUserInputWord()
        {
            playerOneInput = int.Parse(playerOneMove);
            userWordOne = GameElements[playerOneInput];
            playerTwoInput = int.Parse(playerTwoMove);
            userWordTwo = GameElements[playerTwoInput];
            

        }
        public void DisplayUserInputWords()
        {
            GetUserInputWord();
            Console.WriteLine("\n{0} has selected {1}", FirstPlayer.playerName, userWordOne);
            Console.WriteLine("{0} has selected {1}\n", SecondPlayer.playerName, userWordTwo);
        }
        public void DisplayUserInputPhrase(string winnerInput, string loserInput)
        {

            string losingTerm = DisplayInteraction(winnerInput, loserInput);
            Console.WriteLine(winnerInput + " " + losingTerm + " " + loserInput);
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
        public void ResetOption()
        {
            Console.WriteLine("\nWould you like to Play again?\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Y");
            Console.ResetColor();
            Console.Write(" or ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("N\n");
            Console.ResetColor();
            string ResetInput;
            ResetInput = Console.ReadKey(true).KeyChar.ToString();

            if (!(ResetInput == "y" || ResetInput == "n"))
            {
                 ResetOption();
            }
            else if (ResetInput == "y")
            {
                Console.WriteLine("\n");
                Game NextGame = new Game();
            }
            else
            {
                return;
            }
        }

    }

}
