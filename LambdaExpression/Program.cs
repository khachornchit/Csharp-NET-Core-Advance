using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLambdaExpression
{
    delegate void Operation(int num);
    class Program
    {
        static void Main(string[] args)
        {
            // Anonymous Methods and Lambda Expressions
            // Operation legacyOperation = num => { Console.WriteLine("{0} x 2 = {1}", num, num * 2); };

            Action<int> action = num => { Console.WriteLine("Action<int> => {0} x 2 = {1}", num, num * 2); };
            action(5);

            Func<int, int, string> funcMultiply = (x, y) => { return string.Format("{0}x{1}={2}", x, y, x * y); };
            int num1 = 3, num2 = 8;
            Console.WriteLine("Func<int, int, string> => ( {0} , {1} ) => {2}", num1, num2, funcMultiply(num1, num2));
        }
    }
}
