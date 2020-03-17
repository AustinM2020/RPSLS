using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public class Simulation
    {
        Player playerOne = new Player();
        Player playerTwo = new Human();
        Player computer = new AI();
        int scoreOne;
        int scoreTwo;
        
        public Simulation()
        {

        }
        public void GameAI()
        {
            playerTwo.choice = computer.choice;
            Console.WriteLine("PLAYER ONES TURN");
            playerOne.ChooseGesture();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("COMPUTERS TURN");
            computer.ChooseGesture();
            CompareGestures();
            Console.WriteLine("Player One Score: " + scoreOne + "\nComputer Score: " + scoreTwo);
            Console.WriteLine("--------------------------------------------");
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
        }       
        public void CompareGestures()
        {
            if(playerOne.choice == playerTwo.choice)
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
                Console.WriteLine("Player Two Wins Round");
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
                Console.WriteLine("Player Two Wins Round");
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
                Console.WriteLine("Player Two Wins Round");
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
                Console.WriteLine("Player Two Wins Round");
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
                Console.WriteLine("Player Two Wins Round");
            }
        }
    }
}
