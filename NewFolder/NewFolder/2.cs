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
            Double a, f;
            Console.Write("Enter a temp : ");
            a = Convert.ToDouble(Console.ReadLine());
            f = (a * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: " + f);
            Console.ReadKey();
        }
    }
}

