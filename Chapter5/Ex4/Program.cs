using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double var1 = double.Parse(Console.ReadLine());
            double var2 = double.Parse(Console.ReadLine());
            double var3 = double.Parse(Console.ReadLine());
            double min = var1;
            double temp = 0;
            if (var2 > var1)
            {
                temp = var1;
                var1 = var2;
                var2 = temp;
            }
            if (var3 > var1)
            {
                temp = var1;
                var1 = var3;
                var3 = temp;
            }
            if (var3 > var2)
            {
                temp = var3;
                var3 = var2;
                var2 = temp;
            }

            Console.WriteLine("{0},{1},{2}", var1, var2, var3);

        }
    }
}
