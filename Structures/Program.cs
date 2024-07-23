using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct Person
        {
            //by default the structure values are private
            public string name;
            public int age;
            public int birthMonth;

            //constructor
            public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }
        }

        static void Main(string[] args)
        {
            Person person = ReturnPerson();

            Console.ReadLine();
        }

        static Person ReturnPerson()
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Birth Mont: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            return new Person(name, age, birthMonth);
        }
    }
}
//OOP
//structures
//allows us to store different data types inside one data type
//the new keyword creates a new object from constructor
