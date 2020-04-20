using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class StableSort: IAlgorithm
    {
        public List<long> Sort(List<long> list)
        {
            for (int i = 0; i < list.Count-1; i++)
            {

                // Loop invariant : Elements till  
                // a[i - 1] are already sorted. 

                // Find minimum element from  
                // arr[i] to arr[n - 1]. 
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                    if (list[min] > list[j])
                        min = j;

                // Move minimum element at current i. 
                long key = list[min];
                while (min > i)
                {
                    list[min] = list[min - 1];
                    min--;
                }

                list[i] = key;
            }

            return list;
        }
    }
}
