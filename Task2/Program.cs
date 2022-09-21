using System;

namespace Task2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите число N: ");
            int N = int.Parse(Console.ReadLine()) ;
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }
            Console.ReadLine();
        }
    }
}
