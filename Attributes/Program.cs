using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<SampleAttribute>().Count() > 0
                        select t;

            foreach (var t in types)
            {
                Console.WriteLine(t.Name);
                foreach (var p in t.GetProperties())
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }
}
