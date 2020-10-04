using System;

namespace line_comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program \n");
            double x1; double y1; double x2; double y2;
            Console.WriteLine("Enter X coordinate of first point \n");
            x1 =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter Y coordinates of first point \n");
            y1 =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter X coordinate of second point \n");
            x2 =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter Y coordinates of second point\n");
            y2 =Convert.ToDouble (Console.ReadLine());
            double length;
            double diffx;
            double diffy;
            diffx = x2 - x1;
            diffy = y2 - y1;
            length = Math.Sqrt(Math.Pow(diffx, 2) + Math.Pow(diffy, 2));
            Console.WriteLine("Length of line=" + length);

        }
    }
}
