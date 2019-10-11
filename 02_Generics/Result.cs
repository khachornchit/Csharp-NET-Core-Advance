using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance._02_Generics
{
    public class Result<T, U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public U Data2 { get; set; }
    }
}
