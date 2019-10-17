using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    public class SampleAttribute :  Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
