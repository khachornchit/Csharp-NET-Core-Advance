using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person { Name = "John", Age = 24 };
            var p2 = new Person { Name = "Lisa", Age = 19 };
            p1.SayHello(p2);
            p2.SayHello(p1);
        }
    }
}
