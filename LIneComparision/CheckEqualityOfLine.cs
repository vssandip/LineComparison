using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class CheckEqualityOfLine
    {
        public static void Lines()
        {
            double x1, x2, y1, y2;

            double a1, a2, b1, b2;

            Console.WriteLine("Enter the values: ");

            x1 = double.Parse(Console.ReadLine());

            x2 = double.Parse(Console.ReadLine());

            y1 = double.Parse(Console.ReadLine());

            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values: ");

            a1 = double.Parse(Console.ReadLine());

            a2 = double.Parse(Console.ReadLine());

            b1 = double.Parse(Console.ReadLine());

            b2 = double.Parse(Console.ReadLine());

            double Length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            double Length2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));

          /*  if (Length1 == Length2)

            {
                Console.WriteLine("Both lines are equal.");

            }*/
            if (Length1 == Length2)

            {
                Console.WriteLine("Both lines are equal.");

            }
            else if (Length1 > Length2)

            {
                Console.WriteLine("line 1 is greater.");

            }

            else

            {
                Console.WriteLine(" line 2 is smaller.");

            }

        }
    }
}
