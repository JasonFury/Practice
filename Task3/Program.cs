using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j < N - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < 2 * i + 1 ; j++) 
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }
            Console.ReadLine();
        }
    }
}
