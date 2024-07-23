using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenate_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Michael";
            byte age = 25;

            string sentence = string.Concat("Your name is, ", name, " and your age is ", age);

            Console.WriteLine(sentence);

            string[] names = new string[] { "Testing ", "One ", "Two ", "Three ", "! " };

            Console.WriteLine(string.Concat(names));

            Console.ReadLine();


        }
    }
}
