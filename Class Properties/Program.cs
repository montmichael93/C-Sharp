using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Properties
{
    internal class Program
    {
        class Person
        {
            //public string Name { get; set; }
            //public int Id { get; set; }

            //Auto Property if no additional logic is required then the above will suffice

            
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

            //class properties is meant to handle private variables


            //the above code is the same as below

            /*
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    //sets to default value
                    name = value;
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }*/

            public Person(string name, byte age)
            {
                Name = name;
                Age = age;
            }

            public string ReturnDetails() => $"Name: {Name}\nAge: {Age}";
        }

        static void Main(string[] args)
        {
            Person person = new Person("Michael", 25);

            Console.WriteLine(person.ReturnDetails());
            person.Name = "Mikami";
            person.Age = 22;

            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your Name Is {person.Name}");
            Console.WriteLine($"Your Age Is {person.Age}");

            Console.ReadLine();
        }
    }
}
