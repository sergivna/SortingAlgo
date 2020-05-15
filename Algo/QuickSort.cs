using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class QuickSort : IAlgorithm
    {
        public string Name { get; } = "QuickSort";

        public List<long> Sort(List<long> list)
        {
            SortRecur(list, 0, list.Count - 1);
            return list;
        }

        public void SortRecur(List<long> list, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(list, start, end);
            SortRecur(list, start, pivot - 1);
            SortRecur(list, pivot + 1, end);
        }

        public int Partition(List<long> array, int start, int end)
        {
            long temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }

            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }
    }
}
