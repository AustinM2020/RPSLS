using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public abstract class Player
    {
        
        public int choice;
        public string name;
        public int score;
        
        public List<string> Gestures = new List<string>();
        public Player()
        {
            Gestures.Add("Rock");
            Gestures.Add("Paper");
            Gestures.Add("Scissors");
            Gestures.Add("Lizards");
            Gestures.Add("Spock");
        }

        public abstract string ChooseGesture();
        
        public virtual string ChooseName()
        {
            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();
            return name;
        }
        
    }
}
