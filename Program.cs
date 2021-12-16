using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение радиуса: ");
            double r = double.Parse(Console.ReadLine());
            double C = 2 * Math.PI * r;
            double S = Math.PI * (r * r);
            Console.WriteLine("C={0:F2}",C);
            Console.WriteLine("S={0:F2}",S);
            Console.WriteLine();
        }
    }
}
