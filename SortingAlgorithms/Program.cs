using System;
using System.Collections.Generic;
using SortingAlgorithms.Data;

namespace SortingAlgorithms
{
    partial class Program
    {
        static void Main()
        {
            int[] array100 = DataGenerator.GenerateArrayData(100);
            int[] array100R = DataGenerator.GenerateRandomArrayData(100);

            List<int[]> list = new List<int[]>();

            list.Add(array100);
            list.Add(array100R);

            Console.ReadKey();
        }
    }
}
