using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("enter number: ");
            a = int.Parse(Console.ReadLine());
            for (;;)
            {
                Console.Write("enter number: ");
                b = int.Parse(Console.ReadLine());
                if (b != 0)
                {
                    a = a * b;
                    Console.WriteLine(a);
                }
                else
                    break;
            }
            
        }
    }
}
