using System;

namespace LINQ
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
