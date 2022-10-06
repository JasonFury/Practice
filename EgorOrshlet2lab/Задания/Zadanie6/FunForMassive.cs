namespace UniversalFunction
{
    public class FunForMassive
    {
        public static int[] ForMassive(int[] array, int size)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            return array;
        }
    }
} 
