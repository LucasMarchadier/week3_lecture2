using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    abstract class VirtualMotor
    {
        double miles = 10;
        double speed = 100;

        public virtual int Drive(int miles,int speed)
        {
            return (int)Math.Round(((double)miles) / speed, 0);
        }

    }

    class SportsMotorCycle : VirtualMotor
    {
        double _weightRatio = 1.2;

        public override int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles) / speed, 0) * (int)_weightRatio;
        }
    }

    class SportsMotorCycleWithSideCar : VirtualMotor
    {


        double _weightRatio = 0.8; //float
        public override int Drive(int miles, int speed)
        {
            return base.Drive(miles, speed) * (int)_weightRatio;
        }
    }
}
