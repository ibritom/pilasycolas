﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasycolas
{
    internal interface Pila
    {
        void Push(int elemento);
        int Pop();
        int Top();
    }
}
