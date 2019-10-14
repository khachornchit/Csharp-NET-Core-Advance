using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReflection
{
    [MyClass]
    public class Person
    {
        public string Name { get; set; }
        public int Age;
        [MyMethod]
        public void Greeting()
        {
            Console.WriteLine("Hello World !");
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute : Attribute { }      

    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute : Attribute { }
}
