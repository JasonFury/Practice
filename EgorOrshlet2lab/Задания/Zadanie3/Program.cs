using System;
using Zadanie3;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 0, -1, 2, -3, 4 };
        Console.WriteLine($" Сумма неотрицательных чисел = {string.Join(" ", Logic.SumOfPositiveNumbers(array))} ");
        Console.ReadKey();
    }
}