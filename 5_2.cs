using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int Multiply(int a, int b)
        {
            if (b == 0)
                return 0;
            if (b < 0)
                return -Multiply(a, -b);
            return a + Multiply(a, b - 1);
        }

        static void Main()
        {
            Console.Write("enter Number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("enter Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = Multiply(num1, num2);
            Console.WriteLine($"{num1} × {num2} = {result}");
            Console.ReadKey();
        }
    }
}
