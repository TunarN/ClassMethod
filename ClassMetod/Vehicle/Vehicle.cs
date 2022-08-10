using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetod.Vehicle
{
    public class Vehicle
    {
        public string colour;
        public  int Year;
       
        public Vehicle(string colour) 
        {
            this.colour = colour;
        }
        public Vehicle(string colour,int Year):this(colour)
        {
            this.Year = Year;
        }
        
       
        
    }
}
