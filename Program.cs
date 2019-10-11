using CsharpAdvance._02_Generics;
using CsharpAdvance._03_Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {


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
    }

}