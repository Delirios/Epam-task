using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_task
{
    class Rectangle_task_1
    {
        int left_top_x;
        int left_top_y;
        int right_bottom_x;
        int right_bottom_y;
        int aSide;
        int bSide;

        public Rectangle_task_1(int left_top_x, int left_top_y, int right_bottom_x, int right_bottom_y)
        {
            this.left_top_x = left_top_x;
            this.left_top_y = left_top_y;
            this.right_bottom_x = right_bottom_x;
            this.right_bottom_y = right_bottom_y;
            this.aSide = right_bottom_x - left_top_x;
            this.bSide = left_top_y - right_bottom_y;
        }
        public int Perimeter()
        {

            int perimeter = (aSide + bSide) * 2;
            return perimeter;
        }
        public int Square()
        {

            int square = (aSide * bSide);
            return square;
        }
    }
}

