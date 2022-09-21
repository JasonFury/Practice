using System;

namespace Task7
{
     class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.Write(" Введите первое чило: ");
            var a1 = Convert.ToByte(a = Console.ReadLine());
            Console.Write(" Введите второе число: ");
            var b1 = Convert.ToByte(b = Console.ReadLine());
            Console.WriteLine($" Операция Побитовое И = {a1 & b1}");
            Console.WriteLine($" Операция Побитовое ИЛИ = {a1 | b1}");
            Console.WriteLine($" Операция Побитовое исключающее ИЛИ = {a1 ^ b1}");
            Console.ReadKey();
        }
    }
}
