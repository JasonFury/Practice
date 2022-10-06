using System;
using Zadanie2;

class Program
{
    static void Main(string[] args)
    {
        int[,,] array = { { { -1, 2, 3 }, { 4, -5, 6 }, { 7, 8, -9 } } };
        array = Logic.ReplacePositiveNumbers(array);
        Console.Write($" Демонстрация работы программы : ");
        Print(array);
        Console.ReadKey();
    }

    private static void Print(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write(array[i, j, k] + " ");
                }
            }
        }
    }
}