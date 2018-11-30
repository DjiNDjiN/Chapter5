using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte digit = byte.Parse(Console.ReadLine());

            switch (digit)
            {
                case 0: Console.WriteLine("нула"); break;
                case 1: Console.WriteLine("едно"); break;
                case 2: Console.WriteLine("две"); break;
                case 3: Console.WriteLine("три"); break;
                case 4: Console.WriteLine("четири"); break;
                case 5: Console.WriteLine("пет"); break;
                case 6: Console.WriteLine("шест"); break;
                case 7: Console.WriteLine("седем"); break;
                case 8: Console.WriteLine("осем"); break;
                case 9: Console.WriteLine("девет"); break;
                default:
                    Console.WriteLine("грешка"); break;


            }
        }
    }
}
