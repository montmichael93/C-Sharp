using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        /*
        struct Person
        {
            public string name;
            public int age;
                    //will get compiler errors if you don't add parameters // can also give default values
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }*/

        class Person
        {
            public string name;
            public int age;
                           //class constructors can have any parameter
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        } 

        static void Main(string[] args)
        {
            Person person = new Person("Michael", 22);

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);

            Console.ReadLine();
        }
    }
}
//the difference between structures and classes is that you
//don't have to give default values inside the constructor
