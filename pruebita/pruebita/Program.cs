using System;

namespace pruebita
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ingresar un número: ");
            n = int.Parse(Console.ReadLine());

            int[] vec = new int[n];

            Console.WriteLine("Ingresar un número: ");

            vec[n-2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar un número: ");

            vec[n-3] = int.Parse(Console.ReadLine());

            vec[n - 1] = vec[n - 2] + vec[n-3];

            Console.WriteLine("Suma de ambos es " + vec[n - 1]);
        }
    }
}
