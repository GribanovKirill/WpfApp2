using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, b = 1, c, sum = 0;
            Console.WriteLine("Введите n:");
            n = Convert.ToDouble(Console.ReadLine());
            while (b <= n)
            {
                c = 1 / b;
                sum += c;
                b++;
            }
            Console.WriteLine($"Числовой ряд равен {sum}");
            Console.ReadKey();
        } 
    }
}
