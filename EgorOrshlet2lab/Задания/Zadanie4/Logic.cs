using System;


namespace Zadanie4
{
    public class Logic
    {
        public static int SumOfElementsInArray(int[,] myArray, int height, int width)
        {
            int sum = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += myArray[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
