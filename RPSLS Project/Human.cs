using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Human : Player
    {
        public override string ChooseGesture()
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
                case 2:
                    return Gestures[1];
                case 3:
                    return Gestures[2];
                case 4:
                    return Gestures[3];
                case 5:
                    return Gestures[4];
                default:
                    Console.WriteLine("invalid choice, choose again\n");
                    return ChooseGesture();
            }
        }    
            
        
    }
}
