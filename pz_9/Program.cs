using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int[,] A;
            Console.Write("Введите количество строк в матрице: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            n2 = int.Parse(Console.ReadLine());
            A = new int[n1, n2];
            Random rnd = new Random();
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < n2; j++)
                    A[i, j] = rnd.Next(-0, 10 + 1);
            for (int i = 0; i < n1; i++, Console.WriteLine())
                for (int j = 0; j < n2; j++)
                    Console.Write(A[i, j] + "\t");
            int maxRowSum = int.MaxValue, indexmaxRow = 0;
            for (int i = 0; i < n1; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < n2; j++)
                    rowSum += A[i, j];
                if (rowSum > maxRowSum)
                {
                    maxRowSum = rowSum;
                    indexmaxRow = i;
                }
            }
            Console.WriteLine("Строка с максимальной суммой элементов");
            for (int j = 0; j < n2; j++)
                Console.Write(A[indexmaxRow, j] + "\t");
        }
    }
}