using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int N;
            Console.Write("Введите N: ");
            str = Console.ReadLine();
            bool result = int.TryParse(str, out N);
            if (result)
            {
                if (N > 0)
                {
                    for (int i = 0; i <= N; i++)
                    {
                        for (int j = 0; j < N - i; j++)
                        {
                            Console.Write(' ');
                        }
                        for (int j = 0; j < 2 * i + 1; j++)
                        {
                            Console.Write('*');
                        }
                        Console.Write('\n');
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(" Введите корректные значения ");
                }
            }
            else
            {
                Console.WriteLine(" Введите корректные значения ");
            }
        }
    }
}
