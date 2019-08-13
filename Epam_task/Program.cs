using System;

namespace Epam_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Rectangle
            Console.Write("Input left_top_x:  ");
            int left_top_x = Convert.ToInt32( Console.ReadLine());

            Console.Write("Input left_top_y:  ");
            int left_top_y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input right_bottom_x:  ");
            int right_bottom_x = Convert.ToInt32(Console.ReadLine());

            Console.Write("right_bottom_y:   ");
            int right_bottom_y = Convert.ToInt32(Console.ReadLine());


            Rectangle_task_1 rectangle_task_1 = new Rectangle_task_1(left_top_x, left_top_y, right_bottom_x, right_bottom_y);


            Console.WriteLine("Perimeter:{0}, Square: {1};", rectangle_task_1.Perimeter(), rectangle_task_1.Square());





            Rectangle_task_2 task_2 = new Rectangle_task_2();
            Console.Write("Input left_top_x:  ");
            task_2.left_top_x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input left_top_y:  ");
            task_2.left_top_y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input right_bottom_x:  ");
            task_2.right_bottom_x = Convert.ToInt32(Console.ReadLine());

            Console.Write("right_bottom_y:   ");
            task_2.right_bottom_y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Perimeter:{0}, Square: {1};", task_2.Perimeter(), task_2.Square());

            #endregion


            #region Circle
            //Circle circle = new Circle();
            Console.Write("Input radius :  ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Circuit = " + Circle.Circuit(radius));
            Console.WriteLine("Square = " + Circle.CircleSquare(radius));
            #endregion



            #region ComplexNumber

            Console.Write("Input first real  part: ");
            double real = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input  first imaginary  part: ");
            double imaginary = Convert.ToDouble(Console.ReadLine());

            ComplexNumber c1 = new ComplexNumber(real, imaginary);

            Console.Write("Input second real part: ");
            double realSecond = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second imaginary part: ");
            double imaginarySecond = Convert.ToDouble(Console.ReadLine());

            ComplexNumber c2 = new ComplexNumber(realSecond, imaginarySecond);

            ComplexNumber multiplying = c1 * c2;
            Console.WriteLine($"multipling = {multiplying.R} + i * {multiplying.I}");

            ComplexNumber dividing = c1 / c2;
            Console.WriteLine($"dividing = {dividing.R} + i * {dividing.I}");


            #endregion

        }
    }

}
