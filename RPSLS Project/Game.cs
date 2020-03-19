using System;

namespace RPSLS_Project
{
    public class Game
    {
        Player playerOne;
        Player playerTwo;
        
        public int maxScore = 2;
        public int gameChoice;
        public Game()
        {

        }
        public void DisplayRules()
        {
            Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK\nRock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n\nPRESS ENTER TO BEGIN");
            Console.ReadLine();
            ChooseGameType();
        }
        public void ChooseGameType()
        {
            Console.WriteLine("RPSLS\nTYPE 1 FOR AN AI VS HUMAN GAME!\nTYPE 2 TO PLAY YOUR FRIENDS!\nTYPE 3 TO HAVE AN AI ONLY GAME!");
            gameChoice = int.Parse(Console.ReadLine());
            switch (gameChoice)
            {
                case 1:
                    CreatePlayers();
                    RunGame();
                    break;
                case 2:
                    CreatePlayers();
                    RunGame();
                    break;
                case 3:
                    CreatePlayers();
                    RunGame();
                    break;
                default:
                    Console.WriteLine("invalid choice, choose again\n");
                    ChooseGameType();
                    break;
            }
        }
        public void CreatePlayers()
        {
            if (gameChoice == 1)
            {
                playerOne = new Human();
                playerOne.ChooseName();
                playerTwo = new AI();
                playerTwo.ChooseName();
            }
            else if (gameChoice == 2)
            {
                playerOne = new Human();
                playerOne.ChooseName();
                playerTwo = new Human();
                playerTwo.ChooseName();
            }
            else if (gameChoice == 3)
            {
                playerOne = new AI();
                playerOne.ChooseName();
                playerTwo = new AI();
                playerTwo.ChooseName();
                if(playerTwo.name == playerOne.name)
                {
                    playerTwo.ChooseName();
                }
            } 
        }
        public void RunGame()
        {
            do
            {                
                Console.WriteLine(playerOne.name + "'s TURN");
                playerOne.ChooseGesture();
                Console.WriteLine(playerOne.name + " chose: " + playerTwo.choices[playerOne.choice - 1].type);
                Console.ReadLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(playerTwo.name + "'s TURN");
                playerTwo.ChooseGesture();
                Console.WriteLine(playerTwo.name + " chose: " + playerTwo.choices[playerTwo.choice - 1].type);
                Console.ReadLine();
                Console.WriteLine("--------------------------------------------");
                CompareGestures();
                Console.WriteLine(playerOne.name + "'s Score: " + playerOne.score + "\n" + playerTwo.name + "'s Score: " + playerTwo.score);
                Console.WriteLine("--------------------------------------------");
                Console.ReadLine();
            }
            while (playerOne.score < 2 && playerTwo.score < 2);
            if(playerOne.score == maxScore)
            {
                Console.WriteLine(playerOne.name + " WINS THE GAME");
                
            }
            else
            {
                Console.WriteLine(playerTwo.name + " WINS THE GAME");
            }
            Console.WriteLine("Would you like to play again?\ny = Yes\nn = No");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                DisplayRules();
            }
        }
        public void CompareGestures()
        {
            if (playerOne.choices[playerOne.choice - 1].type == playerTwo.choices[playerTwo.choice - 1].type)
            {
                Console.WriteLine("Tie");
            }
            else if (playerTwo.choices[playerTwo.choice - 1].losesTo.Contains(playerOne.choices[playerOne.choice - 1].type))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.choices[playerOne.choice - 1].type + " Beats " + playerTwo.choices[playerTwo.choice - 1].type);
                Console.WriteLine(playerOne.name + " Wins The Round");
            }
            else if (playerOne.choices[playerOne.choice - 1].losesTo.Contains(playerTwo.choices[playerTwo.choice - 1].type))
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo.choices[playerTwo.choice - 1].type + " Beats " + playerOne.choices[playerOne.choice - 1].type);
                Console.WriteLine(playerTwo.name + " Wins The Round");
            }        
        }
    }
}
