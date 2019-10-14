using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGenerics
{
    class ResultDisplay
    {
        public void Show<T, U>(Result<T, U> result)
        {
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);
            Console.WriteLine(result.Data2);
            Console.WriteLine();
        }
    }
}
