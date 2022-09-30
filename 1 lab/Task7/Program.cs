using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.Write(" Введите первое чило: ");
            str1 = Console.ReadLine();
            Console.Write(" Введите второе число: ");
            str2 = Console.ReadLine();
            try
            {
                var a1 = Convert.ToByte(str1);
                var b1 = Convert.ToByte(str2);
                Console.WriteLine($" Операция Побитовое И = {a1 & b1}");
                Console.WriteLine($" Операция Побитовое ИЛИ = {a1 | b1}");
                Console.WriteLine($" Операция Побитовое исключающее ИЛИ = {a1 ^ b1}");
                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine(" Ошибка при конвертации ");
            }
        }
    }
}
