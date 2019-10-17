using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
            Display(firstName: "John", age: 25);
            Display(age: 24);
        }

        static public void Display(string firstName = null, string lastName = null, int age = 0)
        {
            if (firstName != null)
            {
                if (lastName != null)
                {
                    if (age > 0)
                    {
                        Console.WriteLine("{0} {1} is {2} year old", firstName, lastName, age);
                    }
                    else
                    {
                        Console.WriteLine("Hello {0} {1} !", firstName, lastName);
                    }
                }
                else
                {
                    if (age > 0)
                    {
                        Console.WriteLine("{0} is {1} year old", firstName, age);
                    }
                    else
                    {
                        Console.WriteLine("Hello {0}", firstName);
                    }
                }
            }
            else
            {
                if (lastName != null)
                {
                    if (age > 0)
                    {
                        Console.WriteLine("{0} is {1} year old", lastName, age);
                    }
                    else
                    {
                        Console.WriteLine("Hello {0}!", lastName);
                    }
                }
                else
                {
                    if (age > 0)
                    {
                        Console.WriteLine("You are {0} year old", age);
                    }
                    else
                    {
                        Console.WriteLine("Please input some parameters !");
                    }
                }
            }
        }
    }
}
