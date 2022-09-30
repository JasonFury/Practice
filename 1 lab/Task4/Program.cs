using System;

namespace Task4
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
                else
                {
                    Console.WriteLine(" Введите верные значения ");
                }
            }
            else
            {
                Console.WriteLine(" Введите верные значения ");
            }
        }
    }
}