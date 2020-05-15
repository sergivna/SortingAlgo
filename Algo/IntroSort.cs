using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class IntroSort : IAlgorithm
    {
        public string Name { get; } = "IntroSort";

        public long[] Array { get; set; }

        public void BinarySorting()
        {
            BinarySorting(0, Array.Length - 1);
        }

        private void BinarySorting(int left, int right, bool introSort = false)
        {

            int size = right - left + 1;
            if (introSort && size <= Math.Log(Array.Length) * 2)
            {
                PyramidalSorting(left, right);
                return;
            }

            long[] leftArray = new long[size];
            long[] centerArray = new long[size];
            long[] rightArray = new long[size];

            int iLeft = 0, iCenter = 0, iRight = 0;

            int referencePoint = left;

            for (int i = left; i <= right; i++)
                if (Array[i] < Array[referencePoint]) leftArray[iLeft++] = Array[i];
                else if (Array[i] > Array[referencePoint]) rightArray[iRight++] = Array[i];
                else centerArray[iCenter++] = Array[i];

            System.Array.Copy(leftArray, 0, Array, left, iLeft);
            System.Array.Copy(centerArray, 0, Array, left + iLeft, iCenter);
            System.Array.Copy(rightArray, 0, Array, left + iLeft + iCenter, iRight);

            if (iLeft > 1) BinarySorting(left, left + iLeft, introSort);
            if (iRight > 1) BinarySorting(right - iRight + 1, right, introSort);
        }

        public void PyramidalSorting()
        {
            PyramidalSorting(0, Array.Length - 1);
        }

        private void PyramidalSorting(int left, int right)
        {

            int len = right - left + 1;

            for (int i = len / 2 - 1; i >= 0; --i)
            {
                int prev_i = i;
                i = add2pyramid(left, i, len);
                if (prev_i != i) ++i;
            }

            long buf;

            for (int k = len - 1; k > 0; --k)
            {
                buf = Array[left];
                Array[left] = Array[left + k];
                Array[left + k] = buf;

                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = add2pyramid(left, i, k);
                }
            }

        }

        int add2pyramid(int left, int i, int size)
        {

            int imax;
            long buf;

            if ((2 * i + 2) < size)
            {

                if (Array[2 * i + 1 + left] < Array[2 * i + 2 + left])

                    imax = 2 * i + 2;
                else

                    imax = 2 * i + 1;
            }

            else

                imax = 2 * i + 1;

            if (imax >= size) return i;

            if (Array[i + left] < Array[imax + left])
            {

                buf = Array[i + left];
                Array[i + left] = Array[imax + left];
                Array[imax + left] = buf;

                if (imax < size / 2)

                    i = imax;
            }
            return i;
        }

        public List<long> Sort(List<long> list)
        {
            this.Array = list.ToArray();
            BinarySorting(0, Array.Length - 1, true);
            return this.Array.ToList();
        }
    }
}
