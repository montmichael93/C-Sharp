using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_To_String_Function_Override
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get => name;
                set => name = value;
            }
            public int Age
            {
                get => age;
                set => age = value;
            }

            public Person(string name, byte age)
            {
                Name = name;
                Age = age;
            }

            public string ReturnDetails() => $"Name: {Name}\nAge: {Age}";

            //override gets called with just the class name
            public override string ToString()
            {
                return $"Name: {Name}\nAge: {Age}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Person)
                {
                    Person person = obj as Person;
                    return base.Equals(person.name) && age == person.Age;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Michael", 25);
            Person test = new Person("Mikami", 25);

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Not the Same");

            }

            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}
