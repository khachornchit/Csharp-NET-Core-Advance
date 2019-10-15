using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDynamicKeyWordLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic test = "string";
            //test = 12345;
            //Console.WriteLine(test);

            //Python
            //var pythonRuntime = Python.CreateRuntime();
            //dynamic python = pythonRuntime.UseFile("Test.py");
            //python.Greeting();

            dynamic test = new ExpandoObject();
            test.Name = "John";
            test.Age = 24;

            Console.WriteLine(test.Name);
            Console.WriteLine(test.Age);
        }
    }
}
