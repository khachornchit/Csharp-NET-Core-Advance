using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance._09_LINQ
{
    public static class LinqProcessing
    {
        public static void SampleLinq()
        {
            var sample = "NHibernate is a port of Hibernate from Java.";
            var results = from c in sample
                          where c != ' '
                          orderby c
                          group c by c;

            foreach (var item in results)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Count());
            }
        }

        public static void CustomerProcessing()
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
                          where p.Age < 45
                          orderby p.LastName descending
                          group p by p.LastName;

            foreach (var item in results)
            {
                Console.WriteLine("{0} - {1}",item.Key, item.Count());
                foreach (var p in item)
                {
                    Console.Write("\t");
                    p.Display();
                }
            }
        }
    }
}
