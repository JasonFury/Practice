using System;
using Zadanie8;

class Program
{
    static void Main(string[] args)
    {
        int size;
        int number;
        int index = -1;
        Console.Write(" Введите размерность массива: ");
        string str = Console.ReadLine();
        bool result = int.TryParse(str, out size);
        Console.Write(" Введите искомое значение : ");
        string str1 = Console.ReadLine();
        bool result1 = int.TryParse(str1, out number);
        int[] array = new int[size];

        if (result && result1)
        {
            Console.WriteLine($" Изначальный массив : {string.Join(" ", Logic.AddElementsToArray(array, size))}");
            Console.WriteLine($" Индексы элементов : {string.Join(" ", Logic.FindIndex(array, number))}");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine(" Введите корректную размерность ");
            Console.ReadKey();
        }
    }
}