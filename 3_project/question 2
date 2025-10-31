using System;

class Program
{
    static void Main()
    {
        int a = 7;

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++) 
            {
                if (i == 0 || i == a - 1 || i == a / 2 || j == 0)
                    Console.Write("*"); 
                else
                    Console.Write(" "); 
            }
            Console.Write("  "); 

            for (int j = 0; j < a ; j++) 
            {
                if (j == 0 || j == a - 1 || i == a / 2)
                    Console.Write("*"); 
                else
                    Console.Write(" "); 
            }
            Console.Write("  "); 

            for (int j = 0; j < a; j++) 
            {
                if (i == 0 || i == a - 1 || j == a / 2)
                    Console.Write("*");
                else
                    Console.Write(" "); 
            }

            Console.WriteLine();
        }

        Console.ReadKey(); 
    }
}
