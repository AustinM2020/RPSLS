﻿using System;

namespace RPSLS_Project
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();
            game.ChooseGameType();
            Console.ReadLine();
        }
    }
}
