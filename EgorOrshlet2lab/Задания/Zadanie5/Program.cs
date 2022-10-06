using System;
using Zadanie5;
using UniversalFunction;

class Program
{
    static void Main(string[] args)
    {
        int size;
        Console.Write(" Введите размерность массива: ");
        string str = Console.ReadLine();
       bool result = int.TryParse(str, out size);
        int[] array = new int[size];
        if (result)
        {
            Console.WriteLine($" Изначальный массив : {string.Join(" ", FunForMassive.GenerateMassive(array, size))}");
            Console.WriteLine($" Сработала функция : {string.Join(" ", Logic.DeleteNegativeElements(array))}");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine(" Введите корректную размерность ");
            Console.ReadKey();
        }
    }
}