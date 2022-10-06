using System;
using System.Linq;

namespace Zadanie8
{
    public class Logic
    {
        public static int[] AddElementsToArray(int[] array, int size)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 10);
            }
            return array;
        }
        public static int[] FindIndex(int[] array, int number)
        {
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    k += 1;
                }
            }
            int[] tmp1 = new int[k];
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == number)
                {
                    tmp1[count] = j;
                    count++;
                }
            }
            return tmp1;
        }
    }
}
