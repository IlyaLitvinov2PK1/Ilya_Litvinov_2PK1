using System;

namespace pz_16
{
    class Program
    {

        static void pitsa(double N)
        {

            double SO = (System.Math.Pow(N, 2)) * System.Math.PI;
            double VS = (System.Math.Pow(N, 3)) * System.Math.PI * ((double)4 / 3);
            double SS = (System.Math.Pow(N, 2)) * System.Math.PI * 4;
            Console.WriteLine($"Площадь окружности: {SO}\nобъем сферы: {VS}\nплощадь сферы: {SS}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус:");
            pitsa(Convert.ToDouble(Console.ReadLine()));

        }
    }

}