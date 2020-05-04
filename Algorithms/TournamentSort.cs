using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class TournamentSort: IAlgorithm
    {
        public List<long> Sort(List<long> list)
        {

            int num = list.Count;

            //it  will divide total number of elements from 2
            //it will strt checking from 
            for (int i = num / 2; i >= 0; i--)
            {
                swapping(list, num, i);
            }
            //it will remove element from one by one
            //means one by one palyers getting out from the tournament
            for (int i = num - 1; i >= 0; i--)
            {
                if (list[0] > list[i])
                {
                    // swapping current root to end
                    long swap = list[0];
                    list[0] = list[i];
                    list[i] = swap;
                    swapping(list, i, 0);
                }

            }
            //call min heapify on the reduced heap
            return list;
        }
        void swapping(List<long> arr, int n, int k)
        {
            int minimum = k;//we are initializing that the the minimum is the root ;
            int left = 2 * k;//the left child is 2*k index;
            int right = 2 * k + 1;//the right child is 2*k+1 index;
            try
            {

                //it works 
                if (left < n && arr[left] > arr[minimum])
                    minimum = left;//if the left child is lesser than the root it will become a root;


                if (right < n && arr[right] > arr[minimum])
                    minimum = right;//if the right child is lesser than the root than it willl become an root;


                //if the  root is not minimum

                if (minimum != k)
                {
                    long temp = arr[k];//if the root is not minimum then we will swap the root with its minimum child.
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
