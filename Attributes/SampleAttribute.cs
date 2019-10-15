using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    public class SampleAttribute :  Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
