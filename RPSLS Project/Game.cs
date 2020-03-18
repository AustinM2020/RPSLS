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
        public void ChooseGameType()
        {
            Console.WriteLine("RPSLS\nTYPE 1 FOR AN AI GAME!\nTYPE 2 TO PLAY YOUR FRIENDS!");
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
            } 
        }
        public void RunGame()
        {
            do
            {                
                Console.WriteLine(playerOne.name + "'s TURN");
                playerOne.ChooseGesture();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(playerTwo.name + "'s TURN");
                playerTwo.ChooseGesture();
                Console.WriteLine(playerTwo.name + " chose: " + playerTwo.Gestures[playerTwo.choice - 1]);
                CompareGestures();
                Console.WriteLine(playerOne.name + "'s Score: " + playerOne.score + "\n" + playerTwo.name + "'s Score: " + playerTwo.score);
                Console.WriteLine("--------------------------------------------");
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
        }
        public void CompareGestures()
        {
            if (playerOne.choice == playerTwo.choice)
            {
                Console.WriteLine("Tie");
            }
            else if(playerOne.choice != playerTwo.choice)
            {
                RockCheck();
                PaperCheck();
                ScissorsCheck();
                LizardCheck();
                SpockCheck();    
            }        
        }
        public void RockCheck()
        {
            if (playerOne.choice == 1 && (playerTwo.choice == 3 || playerTwo.choice == 4))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " Wins The Round");
            }
            else if(playerTwo.choice == 1 && (playerOne.choice == 3 || playerOne.choice == 4))
            {
                playerTwo.score++;                
                Console.WriteLine(playerTwo.name + " Wins The Round");
            }
        }
        public void PaperCheck()
        {
            if (playerOne.choice == 2 && (playerTwo.choice == 1 || playerTwo.choice == 5))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " Wins The Round");
            }
            else if (playerTwo.choice == 2 && (playerOne.choice == 1 || playerOne.choice == 5))
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo.name + " Wins The Round");

            }
        }
        public void ScissorsCheck()
        {
            if (playerOne.choice == 3 && (playerTwo.choice == 2 || playerTwo.choice == 4))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " Wins The Round");
            }
            else if (playerTwo.choice == 3 && (playerOne.choice == 2 || playerOne.choice == 4))
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo.name + " Wins The Round");
            }
        }
        public void LizardCheck()
        {
            if (playerOne.choice == 4 && (playerTwo.choice == 2 || playerTwo.choice == 5))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " Wins The Round");
            }
            else if (playerTwo.choice == 4 && (playerOne.choice == 2 || playerOne.choice == 5))
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo.name + " Wins The Round");
            }
        }
        public void SpockCheck()
        {
            if (playerOne.choice == 5 && (playerTwo.choice == 1 || playerTwo.choice == 3))
            {
                playerOne.score++;
                Console.WriteLine(playerOne.name + " Wins The Round");
            }
            else if (playerTwo.choice == 5 && (playerOne.choice == 1 || playerOne.choice == 3))
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo.name + " Wins The Round");

            }
        }
    }
}
