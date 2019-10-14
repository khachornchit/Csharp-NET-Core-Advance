using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAttributes
{
    [Sample(Name = "John", Version = 5)]
    public class SampleAttributeTest
    {
        public int Data { get; set; }
        public int Age;
        public void Method1() { }
    }
}
