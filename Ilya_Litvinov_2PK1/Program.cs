using System;

namespace Ilya_Litvinov_2PK1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int size = 10;
            const int x = -1000;
            const int y = 1000;
            int counter = 0;
            int[] arr = new int[size];
            Console.WriteLine("Массив:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(x, y);
                if (arr[i] < 0)
                    counter++;
                Console.WriteLine((i + 1) + ") " + arr[i]);
            }
            Console.WriteLine("\nКоличество отрицательных чисел: " + counter); // извините, не могу вывести все отрицательные числа в порядке уменьшения, только кол-во
            Console.ReadKey();
        }
    }
}
