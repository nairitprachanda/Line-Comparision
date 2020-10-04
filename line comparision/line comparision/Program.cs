using System;

namespace line_comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program \n");
            double x1; double y1; double x2; double y2; double x3; double y3; double x4; double y4;
            Console.WriteLine("Enter coordinates of first point of Line 1 \n");
            x1 =Convert.ToDouble (Console.ReadLine());
            y1 =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter coordinates of second point of Line 1 \n");
            x2 =Convert.ToDouble (Console.ReadLine());
            y2 =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter coordinates of first point of Line 2 \n");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinates of second point of Line 2 \n");
            x4 = Convert.ToDouble(Console.ReadLine());
            y4 = Convert.ToDouble(Console.ReadLine());
            double length1, length2;
            double diffx1, diffx2;
            double diffy1, diffy2;
            diffx1 = x2 - x1;
            diffy1 = y2 - y1;
            diffx2 = x4 - x3;
            diffy2 = y4 - y3;
            length1 = Math.Sqrt(Math.Pow(diffx1, 2) + Math.Pow(diffy1, 2));
            length2 = Math.Sqrt(Math.Pow(diffx2, 2) + Math.Pow(diffy2, 2));
            if (length1 == length2)

                Console.WriteLine("Lines are of EQUAL length");
            else
                Console.WriteLine("Lines are of NOT EQUAL length");

        }
    }
}
