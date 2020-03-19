using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Human : Player
    {
        public override Gestures ChooseGesture()
        {
            for(int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine(i + 1 + ")" + choices[i].type);
            }
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return choices[0];
                case 2:
                    return choices[1];
                case 3:
                    return choices[2];
                case 4:
                    return choices[3];
                case 5:
                    return choices[4];
                default:
                    Console.WriteLine("invalid choice, choose again\n");
                    return ChooseGesture();
            }
            
        }    
            
        
    }
}
