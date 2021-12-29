using System;

namespace SortingAlgorithms.Data
{
    partial class DataGenerator
    {
        public static int[] GenerateArrayData(int arrayDimension)
        {
            int[] array = new int[arrayDimension];

            for (int i = 0; i < arrayDimension; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }

        public static int[] GenerateRandomArrayData(int arrayDimension)
        {
            int[] array = new int[arrayDimension];

            Random random = new();

            for (int i = 0; i < arrayDimension; i++)
            {
                array[i] = random.Next(-1000, 1000);
            }

            return array;
        }
    }
}
