using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public class Gestures
    {
        public string type;
        public List<string> losesTo;
        public Gestures(string type, List<string> losesTo)
        {
            this.type = type;
            this.losesTo = losesTo;
        }
    }
}
