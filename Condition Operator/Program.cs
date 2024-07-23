using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 25;

            Console.WriteLine(age >= 0 ? "Valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
