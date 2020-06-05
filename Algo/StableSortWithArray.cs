using System;
using System.Collections.Generic;
using System.Text;

namespace Algo
{
    public class StableSortWithArray
    {
        public string Name { get; } = "StableSortArray";

        public long[] Sort(long[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[min] > array[j])
                        min = j;

                long key = array[min];
                while (min > i)
                {
                    array[min] = array[min - 1];
                    min--;
                }

                array[i] = key;
            }

            return array;
        }
    }
}
