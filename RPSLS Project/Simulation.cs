using System;

namespace RPSLS_Project
{
    public class Simulation
    {
        Player playerOne = new Human();
        Player playerTwo = new Human();
        Player computer = new AI();
        int scoreOne;
        int scoreTwo;
       
        public Simulation()
        {

        }
        public void StartGame()
        {
            Console.WriteLine("RPSLS\nTYPE 1 FOR AN AI GAME!\nTYPE 2 TO PLAY YOUR FRIENDS!");
            int gameChoice = int.Parse(Console.ReadLine());
            switch (gameChoice)
            {
                case 1:
                    GameAI();
                    break;
                case 2:
                    GameHuman();
                    break;
                default:
                    Console.WriteLine("invalid choice, choose again\n");
                    StartGame();
                    break;
            }
        }
        public void GameAI()
        {
            do
            {                
                Console.WriteLine("PLAYER ONES TURN");
                playerOne.ChooseGesture();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("COMPUTERS TURN");
                computer.ChooseGesture();
                Console.WriteLine("The Computer chose: " + computer.Gestures[computer.choice - 1]);
                CompareGestures();
                Console.WriteLine("Player One Score: " + scoreOne + "\nComputer Score: " + scoreTwo);
                Console.WriteLine("--------------------------------------------");
            }
            while (scoreOne < 3 && scoreTwo < 3);
            if(scoreOne == 3)
            {
                Console.WriteLine("PLAYER ONE WINS THE GAME");
            }
            else
            {
                Console.WriteLine("THE COMPUTER WINS THE GAME");
            }
        }
        public void GameHuman()
        {
            do
            {
                Console.WriteLine("PLAYER ONES TURN");
                playerOne.ChooseGesture();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("PLAYER TWOS TURN");
                playerTwo.ChooseGesture();
                CompareGestures();
                Console.WriteLine("Player One Score: " + scoreOne + "\nPlayer Two Score: " + scoreTwo);
                Console.WriteLine("--------------------------------------------");
            }
            while (scoreOne < 3 && scoreTwo < 3);
            if (scoreOne == 3)
            {
                Console.WriteLine("PLAYER ONE WINS THE GAME");
            }
            else
            {
                Console.WriteLine("PLAYER TWO WINS THE GAME");
            }
        }       
        public void CompareGestures()
        {
            if(computer.choice >= 1)
            {
                playerTwo.choice = computer.choice;
            }
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
                scoreOne++;
                Console.WriteLine("Player One Wins Round");
            }
            else if(playerTwo.choice == 1 && (playerOne.choice == 3 || playerOne.choice == 4))
            {
                scoreTwo++;
                if (computer.choice >= 1)
                {
                    Console.WriteLine("Computer Wins the Round");
                }
                else
                {
                    Console.WriteLine("Player Two Wins Round");
                }
            }
        }
        public void PaperCheck()
        {
            if (playerOne.choice == 2 && (playerTwo.choice == 1 || playerTwo.choice == 5))
            {
                scoreOne++;
                Console.WriteLine("Player One Wins Round");
            }
            else if (playerTwo.choice == 2 && (playerOne.choice == 1 || playerOne.choice == 5))
            {
                scoreTwo++;
                if(computer.choice >= 1)
                {
                    Console.WriteLine("Computer Wins the Round");
                }
                else
                {
                    Console.WriteLine("Player Two Wins Round");
                }
            }
        }
        public void ScissorsCheck()
        {
            if (playerOne.choice == 3 && (playerTwo.choice == 2 || playerTwo.choice == 4))
            {
                scoreOne++;
                Console.WriteLine("Player One Wins Round");
            }
            else if (playerTwo.choice == 3 && (playerOne.choice == 2 || playerOne.choice == 4))
            {
                scoreTwo++;
                if (computer.choice >= 1)
                {
                    Console.WriteLine("Computer Wins the Round");
                }
                else
                {
                    Console.WriteLine("Player Two Wins Round");
                }
            }
        }
        public void LizardCheck()
        {
            if (playerOne.choice == 4 && (playerTwo.choice == 2 || playerTwo.choice == 5))
            {
                scoreOne++;
                Console.WriteLine("Player One Wins Round");
            }
            else if (playerTwo.choice == 4 && (playerOne.choice == 2 || playerOne.choice == 5))
            {
                scoreTwo++;
                if (computer.choice >= 1)
                {
                    Console.WriteLine("Computer Wins the Round");
                }
                else
                {
                    Console.WriteLine("Player Two Wins Round");
                }
            }
        }
        public void SpockCheck()
        {
            if (playerOne.choice == 5 && (playerTwo.choice == 1 || playerTwo.choice == 3))
            {
                scoreOne++;
                Console.WriteLine("Player One Wins Round");
            }
            else if (playerTwo.choice == 5 && (playerOne.choice == 1 || playerOne.choice == 3))
            {
                scoreTwo++;
                if (computer.choice >= 1)
                {
                    Console.WriteLine("Computer Wins the Round");
                }
                else
                {
                    Console.WriteLine("Player Two Wins Round");
                }
            }
        }
    }
}
