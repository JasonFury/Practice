using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string str1, str2;
            Console.WriteLine(" Введите данные прямоугольника ");
            Console.Write(" Введите сторону a: ");
            str1 = Console.ReadLine();
            bool result1 = int.TryParse(str1, out a);
            Console.Write(" Введите сторону b: ");
            str2 = Console.ReadLine();
            bool result2 = int.TryParse(str2, out b);
            if (result1 && result2)
            {
                if (a > 0 && b > 0)
                {
                    Console.Write($" Площадь прямоугольника =  {a * b} ");
                }
                else
                {
                    Console.WriteLine(" Введите корректные значения ");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" Введите корректные значения ");
            }

        }

    }
}