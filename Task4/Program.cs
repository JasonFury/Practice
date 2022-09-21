using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int p = N - 1;
                int k = 1;
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(new string(' ', p));
                    Console.WriteLine(new string('*', k));
                    k += 2;
                    p--;
                }
            }

        }
    }
}