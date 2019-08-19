using System;

namespace Epam_tasks_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            Square_Figure_1 square_Figure_1 = new Square_Figure_1();
            square_Figure_1.Draw();
            Rectangle_Figure_1 rectangle_Figure_1 = new Rectangle_Figure_1();
            rectangle_Figure_1.Draw();
            Console.WriteLine();
            #endregion

            #region Task_2

            Console.Write("Input x:   ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y:   ");
            int y = Convert.ToInt32(Console.ReadLine());
            Square_Figure_2 square_Figure_2 = new Square_Figure_2(x,y);
            square_Figure_2.Draw();
            Rectangle_Figure_2 rectangle_Figure_2 = new Rectangle_Figure_2(x, y);
            rectangle_Figure_2.Draw();
            Console.WriteLine();

            #endregion

            #region Task_3
           
            Square_Figure_3 square_Figure_3 = new Square_Figure_3();
            square_Figure_3.Draw();
            Rectangle_Figure_3 rectangle_Figure_3 = new Rectangle_Figure_3();
            rectangle_Figure_3.Draw();
            Figure_virtual_3 figure_Virtual_3 = new Figure_virtual_3();
            figure_Virtual_3.Draw();
            Console.WriteLine();

            #endregion


            #region Task_4


            Square_Figure_4 square_Figure_4 = new Square_Figure_4();
            Rectangle_Figure_4 rectangle_Figure_4 = new Rectangle_Figure_4();
            Figure_4 figure_4 = new Figure_4();


            Program.DrawAll(square_Figure_4,rectangle_Figure_4,  figure_4);




            #endregion
        }


        public static void DrawAll(params IDrawable_4[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }
}
