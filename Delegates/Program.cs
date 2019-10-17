using System;

namespace Delegates
{
    delegate void MyDelegate(string message);
    delegate void Operation(int num);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Greeting;
            myDelegate("John");

            DeletegateFn(myDelegate, "John");

            Operation operation = Double;
            operation += Tripple;
            ExecuteOperation(operation, 3);
        }
        static void Greeting(string message)
        {
            Console.WriteLine("Hello ! {0}", message);
        }
        static void DeletegateFn(MyDelegate myDelegate, string message)
        {
            myDelegate(message);
        }
        static void Double(int num)
        {
            Console.WriteLine("{0} x 2 = {1}", num, num * 2);
        }
        static void Tripple(int num)
        {
            Console.WriteLine("{0} x 3 = {1}", num, num * 3);
        }
        static void ExecuteOperation(Operation operation, int num)
        {
            operation(num);
        }
    }
}
