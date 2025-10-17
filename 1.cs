using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double circumference = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("masahat: " + circumference);
        Console.WriteLine("mohit: " + area);
        Console.ReadKey();
    }
}
