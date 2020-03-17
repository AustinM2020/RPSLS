using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public abstract class Player
    {
        
        public int choice;
        
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
        
    }
}
