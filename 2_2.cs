using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.Write("enter number: ");
            a = int.Parse(Console.ReadLine());

            if (a % 7 == 0)
            {
                Console.WriteLine("yes!");
            }
            else
            {
                b = a * 3;
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
