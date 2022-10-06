using System;
using System.Runtime.InteropServices;
using UniversalFunction;

namespace Zadanie5
{
    public class Logic
    {

        public static int[] DeleteNegativeElements(int[] array)
        {
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    k += 1;
                }
            }
            int s = 0;
            int[] finalarray = new int[array.Length - k];
            for (int j = 0; j < array.Length; ++j)
            {
                if (array[j] > 0)
                {
                    finalarray[s] = array[j];
                    s++;
                }
            }
            return finalarray;
        }
    }
}


