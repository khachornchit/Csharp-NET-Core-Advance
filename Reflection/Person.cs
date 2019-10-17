using System;

namespace Reflection
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
