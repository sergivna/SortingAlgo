
using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;

public class FranceschiniSort : IAlgorithm
{
    public string Name { get; } = "FranceschiniSort";
    public static void countSort(List<long> list, int exp)
    {
        List<long> output = new List<long>();
        for (int j = 0; j < list.Count; j++)
            output.Add(0);

        int i;
        int[] count = new int[10];


        for (i = 0; i < 10; i++)
            count[i] = 0;

        for (i = 0; i < list.Count; i++)
        {
            var tmp = Math.Abs((list[i] / exp) % 10);
            count[tmp]++;
        }

        for (i = 1; i < 10; i++)
            count[i] += count[i - 1];

        for (i = list.Count - 1; i >= 0; i--)
        {
            var temp = Math.Abs((list[i] / exp) % 10);
            output[count[temp] - 1] = list[i];
            count[temp]--;
        }

        for (i = 0; i < list.Count; i++)
            list[i] = output[i];
    }


    public List<long> Sort(List<long> list)
    {
        long m = list.Max();

        for (int exp = 1; m / exp > 0; exp *= 10)
            countSort(list, exp);

        return list;
    }

}
