﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public interface IAlgorithm
    {
        public string Name { get; }
        List<long> Sort(List<long> ls);
    }
}
