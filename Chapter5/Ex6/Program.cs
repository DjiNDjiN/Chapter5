using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c:");
            int c = int.Parse(Console.ReadLine());

            double x1;
            double x2;
            int dis = (b * b) - (4 * a * c);
            if (dis > 0)
            {
                x1 = (-(double)b - Math.Sqrt(dis)) / (double)2 * a;
                x2 = (-(double)b + Math.Sqrt(dis)) / (double)2 * a;
                Console.WriteLine("{0}\n{1}", x1, x2);
            }
            if (dis == 0)
            {
                x1 = -(double)b / (double)2 * a;
                Console.WriteLine("{0}", x1);
            }
            if (dis < 0) Console.WriteLine("0");

        }
    }
}
