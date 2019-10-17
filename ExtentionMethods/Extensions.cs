using System;

namespace ExtentionMethods
{
    public static class Extensions
    {
        public static void SayHello(this Person p1, Person p2)
        {
            Console.WriteLine("{0} says hello to {1}", p1.Name, p2.Name);
        }
    }
}
