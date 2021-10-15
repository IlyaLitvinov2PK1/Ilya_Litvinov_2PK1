using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int size = 10;
            const int x = -100;
            const int y = 100;
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
            Console.WriteLine("\nКоличество отрицательных элементов: " + counter); // не получается вывести все отрицательные числа в порядке возрастания, извините :(
            Console.ReadKey();

        }
    }
}
        
    

