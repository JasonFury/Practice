using UniversalFunction;
using Zadanie1;
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
            Console.WriteLine($" Максимальное значение в массиве : {Logic.GetMaxValue(array)}");
            Console.WriteLine($" Минимальное значение в массиве : {Logic.GetMinValue(array)}");
            Console.WriteLine($" Сортировка Пузырьком : {string.Join(" ", Logic.BublleSort(array))}");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine(" Введите корректную размерность ");
        }
    }
}