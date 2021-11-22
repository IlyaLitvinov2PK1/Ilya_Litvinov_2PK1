using System;

namespace pz5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, m, j;
            char smv = 'd';
            Console.WriteLine("Задание 1:\n");
            for (i = 30; i <= 100; i = i + 7)
            {
                Console.WriteLine(i + "");
            }
            Console.WriteLine("\nЗадание 2:\n");
            n = 0;
            while (n <= 6)
            {
                n += 1;
                Console.Write(smv + "");
                smv++;
            }
            Console.WriteLine("\n\nЗадание 3:\n");
            n = 4;
            m = 4;
            for (n = 0; n <= 4; n++)
            {
                for (m = 0; m <= 4; m++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nЗадание 4:\n");
            for (i = 0; i <= 100; i++)
            {
                if (i == 0) continue;
                if ((i % 9) != 0) continue;
                Console.WriteLine(i + "");
            }
            Console.WriteLine("\nЗадание 5:\n");
            i = 4;
            j = 50;
            for (i = 4, j = 50; j - i > 11; i++, j--)
            {
                Console.WriteLine("i и j равны: " + i + "и" + j);
            }
        }
    }
}