using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Line_Is_Equal_Greater_Or_Less
    {

        public static void Lines()
        {
            double x1, x2, y1, y2;

            double a1, a2, b1, b2;

            Console.WriteLine("Enter the values: x1 ");

            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values: x2 ");

            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values: y1 ");

            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values: y2 ");

            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values: a1 ");

            a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values: a2 ");

              a2 = double.Parse(Console.ReadLine());
          
             Console.WriteLine("Enter the values: b1 ");

            b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values: b2 ");

            b2 = double.Parse(Console.ReadLine());

            double Length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            double Length2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));

            if (Length1 == Length2)

            {
                Console.WriteLine("Both lines are equal.");

            }
            else

            {
                Console.WriteLine("Both lines are not equal.");

            }

        }

    }
}
