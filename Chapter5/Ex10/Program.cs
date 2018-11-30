using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int y = 0;
            if (!int.TryParse(x, out y))
            {
                Console.WriteLine("Error");
                return;
            }
            switch (y)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(y * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(y * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(y * 1000);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}
