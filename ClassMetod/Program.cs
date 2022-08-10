using ClassMetod.Vehicle;
using System;

namespace ClassMetod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car mercedes = new Car(2012"black","Mercedes","Cls63amg",80,0.14,14);
            mercedes.ShowStatus();
            mercedes.Drive(100);

            
           


        }
        
    }
}
