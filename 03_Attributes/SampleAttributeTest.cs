﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance._03_Attributes
{
    [Sample(Name = "John", Version = 5)]
    public class SampleAttributeTest
    {
        public int Data { get; set; }
        public void Method1() { }
    }
}