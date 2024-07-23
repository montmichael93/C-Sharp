using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Michael";
            byte age = 25;

            Console.WriteLine($"Your name is {name} and your age is {age}");

            Console.ReadLine();
        }
    }
}
