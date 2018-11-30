using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0.Int\n1.Double\n2.string\nChoice:");
            int choice = int.Parse(Console.ReadLine());
            double number;
            string myStr;
            switch (choice)
            {
                case 0:
                    number = int.Parse(Console.ReadLine());
                    number++;
                    Console.WriteLine("{0}", number);
                    break;
                case 1:
                    number = double.Parse(Console.ReadLine());
                    number++;
                    Console.WriteLine("{0}", number);
                    break;
                case 2:
                    myStr = Console.ReadLine();
                    myStr = myStr + "*";
                    Console.WriteLine("{0}", myStr);
                    break;
                default:
                    Console.WriteLine("No such а choice");
                    break;

            }
        }
    }
}
