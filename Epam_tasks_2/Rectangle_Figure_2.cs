using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_tasks_2
{
    class Rectangle_Figure_2 : Figure_abstract_2
    {

        public Rectangle_Figure_2(int x , int y) : base (x , y){ }

        public override void Draw()
        {
            Console.WriteLine("Rectangle_2");
        }
    }
}
