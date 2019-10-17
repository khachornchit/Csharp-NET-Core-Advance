using IronPython.Hosting;
using System;
using System.Dynamic;

namespace DynamicKeyWordLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            // General dynamic
            dynamic testDynamicType = "string";
            testDynamicType = 12345;
            Console.WriteLine("Test dynamic variable : {0}",testDynamicType);

            //Python
            var pythonRuntime = Python.CreateRuntime();
            dynamic python = pythonRuntime.UseFile("IronPython.py");
            python.Greeting();

            dynamic testExpandObject = new ExpandoObject();
            testExpandObject.Name = "John";
            testExpandObject.Age = 24;

            Console.WriteLine("Test expand object : {0}", testExpandObject.Name);
            Console.WriteLine("Test expand object : {0}", testExpandObject.Age);
        }
    }
}
