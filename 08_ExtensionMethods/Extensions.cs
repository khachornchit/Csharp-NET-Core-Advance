using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance._08_ExtensionMethods
{
    public static class Extensions
    {
        public static void SayHello(this Person p1, Person p2)
        {
            Console.WriteLine("{0} says hello to {1}", p1.Name, p2.Name);
        }
    }
}
