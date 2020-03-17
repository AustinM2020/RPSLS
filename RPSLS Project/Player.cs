using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public class Player
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

        public virtual string ChooseGesture()
        {
            for(int i = 0; i < Gestures.Count; i++)
            {
                Console.WriteLine(i+1 + ")" + Gestures[i]);
            }
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return Gestures[0];
                    break;
                case 2:
                    return Gestures[1];
                    break;
                case 3:
                    return Gestures[2];
                    break;
                case 4:
                    return Gestures[3];
                    break;
                case 5:
                    return Gestures[4];
                    break;
                default:
                    Console.WriteLine("invalid choice, choose again\n");
                    return ChooseGesture();
            }
        }    
    }
}
