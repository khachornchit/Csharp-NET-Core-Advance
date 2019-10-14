using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Type : " + type.Name + ", BaseType: " + type.BaseType);

                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine("\tProperty : " + prop.Name + "\tPropertyType : " + prop.PropertyType);
                }

                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine("\tField : " + field.Name + "\tFieldType : " + field.FieldType);
                }

                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethod : " + method.Name);
                }
            }

            var person = new Person { Name = "John", Age = 14 };
            var personType = typeof(Person);
            var nameProperty = personType.GetProperty("Name");
            Console.WriteLine("Property: " + nameProperty.GetValue(person));
            personType.GetMethod("Greeting").Invoke(person, null);

            var assemblyPerson = Assembly.GetExecutingAssembly();
            var typesPerson = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Count() > 0);
            foreach (var type in typesPerson)
            {
                Console.WriteLine(type.Name);
                var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute>().Count() > 0);
                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethod: " + method);
                }
            }
        }
    }
}
