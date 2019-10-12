using CsharpAdvance._02_Generics;
using CsharpAdvance._03_Attributes;
using CsharpAdvance._08_ExtensionMethods;
using CsharpAdvance._09_LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    delegate void MyDelegate(string message);
    //delegate void Operation(int num);

    class Program
    {
        static void Main(string[] args)
        {
            // 09 - LINQ
            //LinqProcessing.SampleLinq();
            LinqProcessing.CustomerProcessing();

            // 08 - Extension Methods
            //var p1 = new Person { Name = "John", Age = 24 };
            //var p2 = new Person { Name = "Lisa", Age = 19 };
            //p1.SayHello(p2);

            // 07 - Events
            //ClockTower tower = new ClockTower();
            //Person john = new Person("John", tower);
            //tower.ChimeSixAM();
            //tower.ChimeFivePM();

            // 06 - Anonymous Methods and Lambda Expressions
            //Operation op = num => { Console.WriteLine("{0} x 2 = {1}", num, num * 2); };
            //Action<int> op = num => { Console.WriteLine("{0} x 2 = {1}", num, num * 2); };
            //Func<int, int, string> Multiply = (x,y) => { return string.Format("{0}x{1}={2}", x, y, x * y); };
            //Console.WriteLine(Multiply(2, 5));

            // 05 - Delegates
            //MyDelegate myDelegate = Greeting;
            //myDelegate("John");
            //DeletegateFn(myDelegate, "John");
            //Operation operation = Double;
            //operation += Tripple;
            //ExecuteOperation(operation, 3);

            // 04 - Reflection
            //var assembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(assembly.FullName);

            //var types = assembly.GetTypes();
            //foreach (var type in types)
            //{
            //    Console.WriteLine("Type : " + type.Name + ", BaseType: " + type.BaseType);

            //    var props = type.GetProperties();
            //    foreach (var prop in props)
            //    {
            //        Console.WriteLine("\tProperty : " + prop.Name + "\tPropertyType : " + prop.PropertyType);
            //    }

            //    var fields = type.GetFields();
            //    foreach (var field in fields)
            //    {
            //        Console.WriteLine("\tField : " + field.Name + "\tFieldType : " + field.FieldType);
            //    }

            //    var methods = type.GetMethods();
            //    foreach (var method in methods)
            //    {
            //        Console.WriteLine("\tMethod : " + method.Name);
            //    }
            //}

            //var person = new Person { Name = "John", Age = 14 };
            //var personType = typeof(Person);
            //var nameProperty = personType.GetProperty("Name");
            //Console.WriteLine("Property: " + nameProperty.GetValue(person));
            //personType.GetMethod("Greeting").Invoke(person, null);

            //var assemblyPerson = Assembly.GetExecutingAssembly();
            //var typesPerson = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Count() > 0);
            //foreach (var type in typesPerson)
            //{
            //    Console.WriteLine(type.Name);
            //    var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute>().Count() > 0);
            //    foreach (var method in methods)
            //    {
            //        Console.WriteLine("\tMethod: " +method);
            //    }
            //}

            //03 - Attribuites
            //var types = from t in Assembly.GetExecutingAssembly().GetTypes()
            //            where t.GetCustomAttributes<SampleAttribute>().Count() > 0
            //            select t;

            //foreach (var t in types)
            //{
            //    Console.WriteLine(t.Name);
            //    foreach (var p in t.GetProperties())
            //    {
            //        Console.WriteLine(p.Name);
            //    }
            //}

            //02 - Generics
            //var result1 = new Result<int, string> { Success = true, Data = 10, Data2="Hello" };
            //var result2 = new Result<string, int> { Success = true, Data = "John", Data2 = 10 };
            //var result3 = new Result<bool, string> { Success = true, Data = true, Data2 = "Hello" };

            //var print = new ResultDisplay();
            //print.Show(result1);
            //print.Show(result2);
            //print.Show(result3);

        }

        static void Greeting(string message)
        {
            Console.WriteLine("Hello ! {0}", message);
        }

        static void DeletegateFn(MyDelegate myDelegate, string message)
        {
            myDelegate(message);
        }

        //static void Double(int num)
        //{
        //    Console.WriteLine("{0} x 2 = {1}", num, num * 2);
        //}

        //static void Tripple(int num)
        //{
        //    Console.WriteLine("{0} x 3 = {1}", num, num * 3);
        //}

        //static void ExecuteOperation(Operation operation, int num)
        //{
        //    operation(num);
        //}
    }
}