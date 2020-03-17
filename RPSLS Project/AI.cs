using System;

namespace RPSLS_Project
{
    class AI : Player
    {
        public  
        
        Random random = new Random();
         
        public override string ChooseGesture()
        {
            choice = random.Next(1, 6);

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
