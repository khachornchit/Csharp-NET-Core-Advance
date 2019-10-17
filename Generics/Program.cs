namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = new Result<int, string> { Success = true, Data = 10, Data2 = "Hello" };
            var result2 = new Result<string, int> { Success = true, Data = "John", Data2 = 10 };
            var result3 = new Result<bool, string> { Success = true, Data = true, Data2 = "Hello" };

            var print = new ResultDisplay();
            print.Show(result1);
            print.Show(result2);
            print.Show(result3);
        }
    }
}
