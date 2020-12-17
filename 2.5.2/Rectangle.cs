using System;

namespace _2._5._2
{
    class AreaOfARectangle
    {
        static void Main()
        {
            //area = w * l

            Console.WriteLine("Please enter the width of your rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length of your rectangle: ");
            double length = double.Parse(Console.ReadLine());

            double area = width * length;

            Console.WriteLine("The calculated area of your rectangle is: {0} ", area);
        }
    }
}