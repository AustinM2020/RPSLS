using System;

namespace RPSLS_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new AI();
            player.ChooseGesture();
            Console.ReadLine();
        }
    }
}
