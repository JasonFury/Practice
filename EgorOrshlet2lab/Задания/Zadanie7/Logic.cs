using System;

namespace Zadanie7
{
    public  class Logic
    {
        public static int[] Sort(int[] array, int size)
        {
            int temp;
            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
