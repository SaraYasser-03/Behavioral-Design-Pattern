﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.Iterators
{
    public interface Iterator
    {
        bool hasNext();
        Object next();

    }
}
