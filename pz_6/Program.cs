using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите длину отрезка a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину отрезка b: ");
            b = Convert.ToInt32(Console.ReadLine());
            while (a >= b)
                a -= b;
            Console.WriteLine(a);
        }
    }
}