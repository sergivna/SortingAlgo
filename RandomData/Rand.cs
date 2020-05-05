using System;
using System.Collections.Generic;

namespace RandomData
{
    public class Rand
    {
        private List<List<long>> list30k;
        private List<List<long>> list100k;
        private List<List<long>> list300k;
        private List<List<long>> list1m;

        public Rand()
        {
            list30k = new List<List<long>>();
            list100k = new List<List<long>>();
            list300k = new List<List<long>>();
            list1m = new List<List<long>>();
        }

        public List<List<List<long>>> GetData(){
            List<List<List<long>>> result = new List<List<List<long>>>();


            FillUniform(list30k, 30000, (long)Math.Pow(2, 31));
            FillUniform(list30k, 30000);
            FillUniform(list30k, 30000, (long)Math.Pow(2, 15));
            FillNormal(list30k, 30000, (long)Math.Pow(2, 31));
           

            FillUniform(list100k, 100000, (long)Math.Pow(2, 31));
            FillUniform(list100k, 100000);
            FillUniform(list100k, 100000, (long)Math.Pow(2, 15));
            FillNormal(list100k, 100000, (long)Math.Pow(2, 31));

            FillUniform(list300k, 300000, (long)Math.Pow(2, 31));
            FillUniform(list300k, 300000);
            FillUniform(list300k, 300000, (long)Math.Pow(2, 15));
            FillNormal(list300k, 300000, (long)Math.Pow(2, 31));

            FillUniform(list1m, 1000000, (long)Math.Pow(2, 31));
            FillUniform(list1m, 1000000);
            FillUniform(list1m, 1000000, (long)Math.Pow(2, 15));
            FillNormal(list1m, 1000000, (long)Math.Pow(2, 31));

            result.Add(list30k);
            result.Add(list100k);
            result.Add(list300k);
            result.Add(list1m);



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
