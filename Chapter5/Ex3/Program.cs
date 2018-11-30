using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal var1 = decimal.Parse(Console.ReadLine());
            decimal var2 = decimal.Parse(Console.ReadLine());
            decimal var3 = decimal.Parse(Console.ReadLine());
            decimal max = var1;

            if (var2 > max)
            {
                max = var2;
            }
            if (var3 > max)
            {
                max = var3;
            }
            Console.WriteLine(max);

        }
    }
}
