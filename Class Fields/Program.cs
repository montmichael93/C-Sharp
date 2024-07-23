using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Fields
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, byte age)
            {
                this.name = name;
                this.age = age;
            }

            public void SetName(string name) =>
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";

            public void SetAge(byte age) => this.age = age >= 0 && age <= 150 ? age : -1;

            public string GetName() => name;

            public int GetAge() => age;

            public string ReturnDetails() => $"Name: {name}\nAge: {age}";

            public void Greeting() => Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            Person person = new Person("Michael", 25);
            person.Greeting();
            person.SetName("Mikami Kyosuke");
            person.SetAge(22);

            Console.WriteLine(person.GetName());
            Console.WriteLine(person.GetAge());

            Console.WriteLine(person.ReturnDetails());
            Console.ReadLine();
        }
    }
}
//local variables take precedence over the class fields 