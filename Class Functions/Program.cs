using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Functions
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }

            public void Greeting()
            {
                Console.WriteLine("Hello World!");
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Michael", 25);
            person.Greeting();
            Console.WriteLine(person.ReturnDetails());
            Console.ReadLine();
        }
    }
}
