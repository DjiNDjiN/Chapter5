using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = int.Parse(Console.ReadLine());
            array[1] = int.Parse(Console.ReadLine());
            array[2] = int.Parse(Console.ReadLine());
            array[3] = int.Parse(Console.ReadLine());
            array[4] = int.Parse(Console.ReadLine());
            int flagFound = 0;

            if ((array[0] + array[1]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[0], array[1]); flagFound = 1; }
            if ((array[0] + array[2]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[0], array[2]); flagFound = 1; }
            if ((array[0] + array[3]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[0], array[3]); flagFound = 1; }
            if ((array[0] + array[4]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[0], array[4]); flagFound = 1; }
            if ((array[1] + array[2]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[1], array[2]); flagFound = 1; }
            if ((array[1] + array[3]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[1], array[3]); flagFound = 1; }
            if ((array[1] + array[4]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[1], array[4]); flagFound = 1; }
            if ((array[2] + array[3]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[2], array[3]); flagFound = 1; }
            if ((array[2] + array[4]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[2], array[4]); flagFound = 1; }
            if ((array[3] + array[4]) == 0)
            { Console.WriteLine("{0} {1} is 0", array[3], array[4]); flagFound = 1; }

            if ((array[0] + array[1] + array[2]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[0], array[1], array[2]); flagFound = 1; }
            if ((array[0] + array[1] + array[3]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[0], array[1], array[3]); flagFound = 1; }
            if ((array[0] + array[1] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[0], array[1], array[4]); flagFound = 1; }
            if ((array[0] + array[2] + array[3]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[0], array[2], array[3]); flagFound = 1; }
            if ((array[0] + array[2] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[0], array[2], array[4]); flagFound = 1; }
            if ((array[0] + array[3] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[0], array[3], array[4]); flagFound = 1; }
            if ((array[1] + array[2] + array[3]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[1], array[2], array[3]); flagFound = 1; }
            if ((array[1] + array[2] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[1], array[2], array[4]); flagFound = 1; }
            if ((array[1] + array[3] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[1], array[3], array[4]); flagFound = 1; }
            if ((array[2] + array[3] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} is 0", array[2], array[3], array[4]); flagFound = 1; }

            if ((array[0] + array[1] + array[2] + array[3]) == 0)
            { Console.WriteLine("{0} {1} {2} {3} is 0", array[0], array[1], array[2], array[3]); flagFound = 1; }
            if ((array[0] + array[1] + array[2] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} {3} is 0", array[0], array[1], array[2], array[4]); flagFound = 1; }
            if ((array[0] + array[2] + array[3] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} {3} is 0", array[0], array[2], array[3], array[4]); flagFound = 1; }
            if ((array[1] + array[2] + array[3] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} {3} is 0", array[1], array[2], array[3], array[4]); flagFound = 1; }

            if ((array[0] + array[1] + array[2] + array[3] + array[4]) == 0)
            { Console.WriteLine("{0} {1} {2} {3} {4} is 0", array[0], array[1], array[2], array[3], array[4]); flagFound = 1; }

            if (flagFound == 0) Console.WriteLine("No subset sum of 0 found");


        }
    }
}
