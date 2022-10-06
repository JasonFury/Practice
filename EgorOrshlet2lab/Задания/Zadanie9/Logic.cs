using System;

namespace Zadanie9
{
    public class Logic
    {
        public static void CheckEqualsTwoArray(int[] array, int[] array1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array[i] == array1[j])
                    {
                        Console.WriteLine(" Массивы одинаковые ");
                        break;
                    }
                }
                break;
            }
        }
    }
}
