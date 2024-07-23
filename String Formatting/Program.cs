using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Michael";
            byte age = 25;
            //composite string formatting
            Console.WriteLine("Your name is {0} ,and your age is {1}", name, age);
            Console.WriteLine();
            Console.WriteLine("Name: {0}\nAge: {1}", name, age);

            Console.ReadLine();
        }
    }
}
