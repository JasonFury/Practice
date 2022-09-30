using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine(" Введите стороны треугольника ");
            Console.Write(" Введите сторону a: ");
            string str1 = Console.ReadLine();
            float.TryParse(str1, out a);
            Console.Write(" Введите сторону b: ");
            string str2 = Console.ReadLine();
            float.TryParse(str2, out b);
            Console.Write(" Введите сторону c: ");
            string str3 = Console.ReadLine();
            float.TryParse(str3, out c);



            if ((b + c > a) && (c + a > b) && (a + b > c))
            {
                float p = (a + b + c) / 2;
                Console.WriteLine($" Площадь треугольника равна = {(float)Math.Sqrt(p * (p - a) * (p - b) * (p - c))} ");
            }
            else
            {
                Console.WriteLine(" Треугольник существовать не может ");
            }
            Console.ReadLine();
        }
    }
}
