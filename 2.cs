using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a,d;
            Console.Write("Enter a temp : ");
            a = Double.Parse(Console.ReadLine());
            d = a * 1.8 + 32;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
