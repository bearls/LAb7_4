using System;
using System.Collections.Generic;
using System.Text;



namespace Lab7_4_BarryEarls
{ 

 
    class Program
    { 
    
        static void Main(string[] args)
        {
            DatingProfile andy = new DatingProfile("Andy", "Stitzer", 40, "Male");
            andy.WriteBio("Love collecting action figures.");

            DatingProfile trish = new DatingProfile("Trish", "Piedmont", 40, "Female");
            trish.WriteBio("Hot Milf");

            andy.SendMessage("Hello Trish", "Im a virgin.", trish);
            trish.ReadMessage();
        }
    }
}
