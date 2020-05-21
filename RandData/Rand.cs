using System;
using System.Collections.Generic;

namespace RandomData
{
    public class Rand
    {
        private List<List<long>> list30k1;
        private List<List<long>> list30k2;
        private List<List<long>> list30k3;
        private List<List<long>> list30k4;
        private List<List<long>> list100k1;
        private List<List<long>> list100k2;
        private List<List<long>> list100k3;
        private List<List<long>> list100k4;
        private List<List<long>> list300k1;
        private List<List<long>> list300k2;
        private List<List<long>> list300k3;
        private List<List<long>> list300k4;
        private List<List<long>> list1m1;
        private List<List<long>> list1m2;
        private List<List<long>> list1m3;
        private List<List<long>> list1m4;

        public List<List<List<long>>> GetData()
        {
            List<List<List<long>>> result = new List<List<List<long>>>();

            list30k1 = new List<List<long>>();
            list30k2 = new List<List<long>>();
            list30k3 = new List<List<long>>();
            list30k4 = new List<List<long>>();
            list100k1 = new List<List<long>>();
            list100k2 = new List<List<long>>();
            list100k3 = new List<List<long>>();
            list100k4 = new List<List<long>>();
            list300k1 = new List<List<long>>();
            list300k2 = new List<List<long>>();
            list300k3 = new List<List<long>>();
            list300k4 = new List<List<long>>();
            list1m1 = new List<List<long>>();
            list1m2 = new List<List<long>>();
            list1m3 = new List<List<long>>();
            list1m4 = new List<List<long>>();

            FillUniform(list30k1, 30000, (long)Math.Pow(2, 31));
            FillUniform(list30k2, 30000);
            FillUniform(list30k3, 30000, (long)Math.Pow(2, 15));
            FillNormal(list30k4, 30000, (long)Math.Pow(2, 31));

            FillUniform(list100k1, 100000, (long)Math.Pow(2, 31));
            FillUniform(list100k2, 100000);
            FillUniform(list100k3, 100000, (long)Math.Pow(2, 15));
            FillNormal(list100k4, 100000, (long)Math.Pow(2, 31));

            FillUniform(list300k1, 300000, (long)Math.Pow(2, 31));
            FillUniform(list300k2, 300000);
            FillUniform(list300k3, 300000, (long)Math.Pow(2, 15));
            FillNormal(list300k4, 300000, (long)Math.Pow(2, 31));

            FillUniform(list1m1, 1000000, (long)Math.Pow(2, 31));
            FillUniform(list1m2, 1000000);
            FillUniform(list1m3, 1000000, (long)Math.Pow(2, 15));
            FillNormal(list1m4, 1000000, (long)Math.Pow(2, 31));

            result.Add(list30k1);
            result.Add(list30k2);
            result.Add(list30k3);
            result.Add(list30k4);

            result.Add(list100k1);
            result.Add(list100k2);
            result.Add(list100k3);
            result.Add(list100k4);

            result.Add(list300k1);
            result.Add(list300k2);
            result.Add(list300k3);
            result.Add(list300k4);

            result.Add(list1m1);
            result.Add(list1m2);
            result.Add(list1m3);
            result.Add(list1m4);

            return result;
        }

        private void FillUniform(List<List<long>> list, long N, long end = -1)
        {
            List<long> ls = new List<long>();
            Random random = new Random();

            if (end == -1)
                end = N - 1;
            long next = 0;

            for (int i = 0; i < 5; i++)
            {
                ls.Clear();

                for (int j = 0; j < N; j++)
                {
                    next = (long)(random.NextDouble() * end);
                    ls.Add(next);
                }

                list.Add(ls);
            }
        }

        private void FillNormal(List<List<long>> list, long N, long end = -1)
        {
            List<long> ls = new List<long>();
            NormalRandom random = new NormalRandom();

            if (end == -1)
                end = N - 1;
            long next = 0;

            for (int i = 0; i < 5; i++)
            {
                ls.Clear();

                for (int j = 0; j < N; j++)
                {
                    next = (long)(random.NextGaussian());
                    ls.Add(next);
                }

                list.Add(ls);
            }
        }

    }
}
