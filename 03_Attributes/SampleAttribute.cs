using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance._03_Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    public class SampleAttribute :  Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
