using System;
using System.Drawing;

namespace Zadanie6
{
    public class Logic
    {
        public static int[] DoubleElements(int[] array)
        {
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    k += 1;
                }
            }
            int s = 0;
            int[] tmp = new int[array.Length + k];
            for(int j = 0; j < array.Length; ++j)
            {
                if (array[j] >= 0)
                {
                    tmp[s] = array[j];
                    s++;
                }
                else if (array[j] < 0)
                {
                    tmp[s] = array[j];
                    s++;
                    tmp[s] = array[j];
                    s++;
                }
            }
            return tmp;
        }
    }
}
