using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0 && z > 0)
            {
                Console.WriteLine("+");
            }
            else if (x < 0 && y < 0 && z > 0)
            {
                Console.WriteLine("+");
            }
            else if (x > 0 && y < 0 && z < 0)
            {
                Console.WriteLine("+");
            }
            else if (x < 0 && y > 0 && z < 0)
            {
                Console.WriteLine("+");
            }
            else if (x == 0 || y == 0 || z == 0)
            {
                Console.WriteLine("It's zero result");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }    }    
