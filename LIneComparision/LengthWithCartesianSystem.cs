using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LengthWithCartesianSystem
    {
        public static void Lines()
        {
            double x1, x2, y1, y2;

            Console.WriteLine("Enter the value of x1 : ");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of x2 : ");
             x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y1 : ");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y2 : ");
            y2 = double.Parse(Console.ReadLine());

            double length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine("The length between the two point is: "  +  length);
        }
    }
}
