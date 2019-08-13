using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_task
{
    static class Circle
    {
       
        const double Pi = 3.14;
        public static double Circuit(double radius)           
        {
            double Circuit = 2 * Pi * radius;
            return Circuit;
        }


        public static double CircleSquare(double radius)
        {

            double Square = radius * radius * Pi;
            return Square;
        }
    }
}
