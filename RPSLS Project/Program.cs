using System;

namespace RPSLS_Project
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Simulation game = new Simulation();
            game.StartGame();
            Console.ReadLine();
        }
    }
}
