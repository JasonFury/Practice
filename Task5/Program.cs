using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    k += i;
                }
            }
            Console.WriteLine(k);
        }
    }
}
