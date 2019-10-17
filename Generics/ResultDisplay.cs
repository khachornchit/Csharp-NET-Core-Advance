using System;

namespace Generics
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
