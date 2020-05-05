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

        private List<long> range;

        public Rand()
        {
            list30k = new List<List<long>>(20);
            list100k = new List<List<long>>(20);
            list300k = new List<List<long>>(20);
            list1m = new List<List<long>>(20);

            range = new List<long>();
        }

        public List<List<List<long>>> GetData(){
            List<List<List<long>>> result = new List<List<List<long>>>();


            FillUniform(list30k, 30000, (long)Math.Pow(2, 31));
            FillUniform(list30k, 30000);
            FillUniform(list30k, 30000, (long)Math.Pow(2, 15));
           

            FillUniform(list100k, 100000, (long)Math.Pow(2, 31));
            FillUniform(list100k, 100000);
            FillUniform(list100k, 100000, (long)Math.Pow(2, 15));

            FillUniform(list300k, 300000, (long)Math.Pow(2, 31));
            FillUniform(list300k, 300000);
            FillUniform(list300k, 300000, (long)Math.Pow(2, 15));

            FillUniform(list1m, 1000000, (long)Math.Pow(2, 31));
            FillUniform(list1m, 1000000);
            FillUniform(list1m, 1000000, (long)Math.Pow(2, 15));

            result.Add(list30k);
            result.Add(list100k);
            result.Add(list300k);
            result.Add(list1m);



            return result;
        }

        private void FillUniform(List<List<long>> list, long N, long end = -1)
        {
            List<long> ls = new List<long>();//1 - 30 тис 
            Random random = new Random();

            if (end == -1)
                end = N - 1;
            long next = 0;
            //long start = 0;
            //long end = (long)Math.Pow(2, 31);
            //long dif = end - start;


                for (int i = 0; i < 5; i++)
                {
                    ls.Clear();

                    for (int j = 0; j < N; j++)
                    {
                        next = random.Next() * end;
                        ls.Add(next);
                    }

                    list.Add(ls);
                }
            
            
        }
        
    }
}
