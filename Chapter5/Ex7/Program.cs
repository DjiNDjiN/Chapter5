using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double var1 = double.Parse(Console.ReadLine());
            double var2 = double.Parse(Console.ReadLine());
            double var3 = double.Parse(Console.ReadLine());
            double var4 = double.Parse(Console.ReadLine());
            double var5 = double.Parse(Console.ReadLine());

            if (var1 > var2 && var1 > var3 && var1 > var4 && var1 > var5)
                Console.WriteLine("{0}", var1);
            else if (var2 > var1 && var2 > var3 && var2 > var4 && var2 > var5)
                Console.WriteLine("{0}", var2);
            else if (var3 > var2 && var3 > var1 && var3 > var4 && var3 > var5)
                Console.WriteLine("{0}", var3);
            else if (var4 > var2 && var4 > var3 && var4 > var1 && var4 > var5)
                Console.WriteLine("{0}", var4);
            else if (var5 > var2 && var5 > var3 && var5 > var4 && var5 > var1)
                Console.WriteLine("{0}", var5);

        }
    }
}
