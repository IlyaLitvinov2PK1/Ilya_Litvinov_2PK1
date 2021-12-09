using System;

namespace pz_18
{
    class Program
    {
        //Задание 1
        static int Sushi(int a1, int d, int n)
        {

            if (n < 0) { Console.WriteLine("Как такое может быть?"); return 0; }
            if (n == 0) { Console.WriteLine(0); return 0; }
            if (n == 1) { Console.WriteLine(a1); return a1; }
            else { a1 = a1 + d; n = n - 1; return Sushi(a1, d, n); }

        }
        //Задание 2
        static double Vareniki(double b1, double q, int n)
        {
            if (n < 0) { Console.WriteLine("Как такое может быть?"); return 0; }
            if (n == 0) { Console.WriteLine(0); return 0; }
            if (n == 1) { Console.WriteLine(b1); return b1; }
            else { b1 = b1 * q; n = n - 1; return Vareniki(b1, q, n); }

        }
        //Задание 3
        static int Ikrinka(int A, int B)
        {
            if (A == B) { Console.WriteLine($"{A}\n"); return 0; }
            else { Console.Write($"{A} "); A += 1; }
            return Ikrinka(A, B);
        }
        //Задание 4
        static int Summ(int x, int e)
        {
            if (x == 1) { Console.WriteLine($"Сумма чисел = {e + 1 } "); } //aswdqwdqwdqwd
            else { e = e + x; x = x - 1; return Summ(x, e); }
            return 1;
        }
        static void Main(string[] args)
        {
            Console.Write("Задание №1\nВведите номер члена арифметической прогрессии:");
            int n = Convert.ToInt16(Console.ReadLine());
            Sushi(-10, -2, n);
            Console.Write("Задание №2\nВведите номер геометрической прогрессии:");
            n = Convert.ToInt16(Console.ReadLine());
            Vareniki(12, -2, n);
            Console.Write("задание №3\nУ нас уже есть число А = 6 и число В = 54. Нужно найти числа между ними:");
            Ikrinka(6, 54);
            Console.Write($"Задание №4\nВведите число n:");
            n = Convert.ToInt16(Console.ReadLine());
            Summ(n, 0);
        }
    }
}