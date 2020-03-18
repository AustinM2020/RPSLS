using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public class AI : Player
    {
        Random random = new Random();

        List<string> Names = new List<string>();
        public AI()
        {
            Names.Add("Aaron");
            Names.Add("Frank");
            Names.Add("CJ");
            Names.Add("Jack");
            Names.Add("Chris");

        } 
        public override string ChooseGesture()
        {
            choice = random.Next(1, 6);

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
        public override string ChooseName()
        {
            int choice = random.Next(1, 6);
            name = Names[choice];
            Console.WriteLine("Tha AI will be named: " + name);
            return name;
        }
    }
}
