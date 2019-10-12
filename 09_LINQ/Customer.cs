using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance._09_LINQ
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void Display()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName, Age);
        }
    }
}
