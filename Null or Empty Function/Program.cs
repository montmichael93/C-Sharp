using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_or_Empty_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //checks the value in the memory
            if (name != "")
            {
                Console.WriteLine("0");
            }

            //checks the output value
            if (!name.Equals(""))
            {
                Console.WriteLine("1");
            }

            //checks if sting is null //because an empty string still has a value
            if (string.IsNullOrEmpty(name)) {
                Console.WriteLine("this is null or empty");
            }

            Console.WriteLine($"Your name is {name}");

            Console.ReadLine();
        }
    }
}
//a method done on something null will crash the program