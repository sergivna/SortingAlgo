using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class TournamentSort: IAlgorithm
    {
        public string Name { get; } = "TournamentSort";

        public List<long> Sort(List<long> list)
        {
            int num = list.Count;

            for (int i = num / 2; i >= 0; i--)
            {
                swapping(list, num, i);
            }

            for (int i = num - 1; i >= 0; i--)
            {
                if (list[0] > list[i])
                {

                    long swap = list[0];
                    list[0] = list[i];
                    list[i] = swap;
                    swapping(list, i, 0);
                }

            }

            return list;
        }
        void swapping(List<long> arr, int n, int k)
        {
            int minimum = k;
            int left = 2 * k;
            int right = 2 * k + 1;
            try
            {
                if (left < n && arr[left] > arr[minimum])
                    minimum = left;

                if (right < n && arr[right] > arr[minimum])
                    minimum = right;

                if (minimum != k)
                {
                    long temp = arr[k];
                    arr[k] = arr[minimum];
                    arr[minimum] = temp;
                    swapping(arr, n, minimum);

                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("array index out of bpunds" + e.Message);
            }
        }
    }
}
