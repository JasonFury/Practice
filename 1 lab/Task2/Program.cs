using System;

namespace Task2
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
                        for (int j = 0; j <= i; j++)
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
