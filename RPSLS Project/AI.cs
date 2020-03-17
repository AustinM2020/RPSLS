using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class AI : Player
    {
        Random random = new Random();
        
        
        
        public override string ChooseGesture()
        {
            int choice = random.Next(1, 5);

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
