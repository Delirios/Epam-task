using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_tasks_2
{
    abstract class Figure_abstract_2
    {
        public readonly int X;
        public readonly int Y;


        public Figure_abstract_2(int x , int y)
        {
            this.X = x;
            this.Y = y;
        }
        public abstract void Draw();
    }

}
