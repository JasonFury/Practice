using System;

namespace Zadanie3
{
    public class Logic
    {
        public static int SumOfPositiveNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

    }
}
