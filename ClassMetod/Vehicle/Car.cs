using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetod.Vehicle
{
     public class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public double FuelFor1km;
        public int CurrentFuel;
        
        public Car(int Year,string colour, string Brand, string Model, int FuelCapacity, double FuelFor1km , int CurrentFuel):base(colour,Year)
        {
            this.Year = Year;
            this.colour = colour;
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1km = FuelFor1km;
            this.CurrentFuel = CurrentFuel;
            
        }
        public void ShowStatus()
        {
            Console.WriteLine($"{Year} {colour} {Brand} {Model} {FuelCapacity} {FuelFor1km} {CurrentFuel}");
        }

        
        public void Drive(double way)
        {
            double wayFuel = way * FuelFor1km;
            if (CurrentFuel >wayFuel)
            {
                double restofFuel = CurrentFuel - wayFuel;
                Console.WriteLine( "qalan benzin: "+restofFuel);
            }
            else
            {
                Console.WriteLine("masinda yeteri qeder benzin olmadigi ucun gede bilmir");
            }
            
            
           
        }

    }
}
