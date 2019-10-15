using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer{FirstName="John", LastName="Doe", Age = 25},
                new Customer{FirstName="Jane", LastName="Doe", Age = 26},
                new Customer{FirstName="Lisa", LastName="Williams", Age = 41},
                new Customer{FirstName="Sumantha", LastName="Williams", Age = 34},
                new Customer{FirstName="Bob", LastName="Water", Age = 12},
            };

            var results = from p in customers
                          where p.LastName == "Williams"
                          select new {
                              FullName = string.Format("{0} {1}", p.FirstName, p.LastName)
                          };

            foreach (var c in results)
            {
                Console.WriteLine(c.FullName);
            }
        }
    }

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
