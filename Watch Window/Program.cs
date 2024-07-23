using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch_Window
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Michael";
            int age;
            age = 22;

            printDetails(name, age);

            Console.WriteLine(name);

           
            Console.ReadLine();

        }


        static void printDetails(string givenName, int givenAge)
        {
            Console.WriteLine($"My name is {givenName} and i am {givenAge} ");
        }




    }
}
