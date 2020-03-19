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
        public override Gestures ChooseGesture()
        {
            choice = random.Next(1, 6);
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
                    return ChooseGesture();
            }
        }
        public override string ChooseName()
        {
            int choice = random.Next(1, 5);
            name = Names[choice];
            Console.WriteLine("The AI will be named: " + name);
            
            return name;
        }
    }
}
