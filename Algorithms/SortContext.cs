using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SortContext
    {
        private IAlgorithm algorithm;

        public SortContext()
        {}

        public SortContext(IAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }

        public IAlgorithm Algo
        {
            get
            {
                return algorithm;
            }
            set
            {
                this.algorithm = value;
            }
        }

        public void Sort()
        {
            if (algorithm == null)
                throw new ArgumentNullException();

            algorithm.Sort();
        }
    }
}
