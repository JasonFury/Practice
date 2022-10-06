using System;
using System.Collections;
using System.Linq;
//using Zadanie7;
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
            Console.WriteLine($" Изначальный массив : {string.Join(" ", FunForMassive.GenerateArray(array, size))}");
            Array.Sort(array);
            Array.Reverse(array);
            Console.Write(" Отсортированный массив : ");
            PrintArray(array);
            Console.ReadLine();
        }


        else
        {
            Console.WriteLine(" Введите корректную размерность ");
            Console.ReadKey();
        }
        }

    private static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");

        }
    }
}
