using System;
using Zadanie4;

class Program
{
    static void Main(string[] args)
    {
        int[,] myArray = new int[,]
        {
                {1, 3, 3, 4, 5},
                {5, 6, 7, 8, 9},
                {10, 11, 12, 13, 14},
                {15, 16, 17, 18, 19},
                {20, 21, 22, 23, 24}
        };
        int height = myArray.GetLength(0); // количество строк
        int width = myArray.GetLength(1); // количество столбцов
        Print(myArray);
        Console.WriteLine($"Сумма элементов =  {Logic.SumOfElementsInArray(myArray)}");

    }

    private static void Print(int[,] myArray, int height, int width)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(myArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}