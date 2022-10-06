using System;
using System.Drawing;
using Zadanie9;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3 };
        int[] array1 = { 3, 1, 2 };
        Array.Sort(array);
        Array.Sort(array1);
        //Console.WriteLine($" массив : {string.Join(" ", Logic.Check(array, array1))}");
        Logic.CheckEqualsTwoArray(array, array1);
        Console.ReadKey();
    }
}