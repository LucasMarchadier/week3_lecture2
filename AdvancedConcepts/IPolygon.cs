using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    interface IPolygon
    {
        string Name
        {
            get;
            set;
        }
        int NumOfSides
        {
            get;
            //set; // didn't work

        }
        void calculateArea(int[] sides);
        
        


    }
}
