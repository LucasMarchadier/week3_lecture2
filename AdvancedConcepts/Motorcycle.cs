using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    abstract class Motorcycle
    {
        /* 
         //Anyone can call this
         public void StartEngine(); //methode statements here 

         //only derived classes can call this 
         protected void AddGas(int gallons);

         //derived classes can override the base class implementation
         public virtual int Drive(int miles, int speed)
         {return 1;}

         //derived classes must implement this
         public abstract double GetTopSpeed();
         */

        //Derived classes must implement this
        public abstract double GetTopSpeed();
    }

    class SportsMotorcycle : Motorcycle
    {
        public override double GetTopSpeed()
        {
            return 70.05;
        }



    }
}
