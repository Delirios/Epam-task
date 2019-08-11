using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_task
{
    class Rectangle_task_2
    {

        public int left_top_x { get; set; }

        public int left_top_y { get; set; }

        public int right_bottom_x { get; set; }
        
        public int right_bottom_y { get; set; }


        public int Perimeter()
        {

            int aSide = right_bottom_x - left_top_x;
            int bSide = left_top_y - right_bottom_y;

            int perimeter = (aSide + bSide) * 2;
            return perimeter;
        }
        public int Square()
        {

            int aSide = right_bottom_x - left_top_x;
            int bSide = left_top_y - right_bottom_y;

            int square = (aSide * bSide);
            return square;
        }
    }


}
