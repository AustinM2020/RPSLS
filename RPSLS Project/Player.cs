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
        public List<Gestures> choices;
        public Player()
        {
            choices = new List<Gestures>() { new Gestures("Rock", new List<string> { "Paper", "Spock" }),
                new Gestures("Paper", new List<string> { "Scissors", "Lizard" }),
                new Gestures("Scissors", new List<string> { "Rock", "Spock" }),
                new Gestures("Lizard", new List<string> { "Scissors", "Rock" }),
                new Gestures("Spock", new List<string> { "Paper", "Lizard" }) };
        }
        
            
        

        public abstract Gestures ChooseGesture();
        
        public virtual string ChooseName()
        {
            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();
            return name;
        }
        
    }
}
