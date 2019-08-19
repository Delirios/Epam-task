using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_tasks_2
{
    class Square_Figure_2 : Figure_abstract_2
    {

        public Square_Figure_2(int x, int y) : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine("Square_2");
        }
    }
}
