using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int num = 10;
            string name = "banjo";

            //Assign(ref num, ref name);
            //Console.WriteLine(num);

            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}!");
            }
            else
            {
                Console.WriteLine("New name can not be empty or null");
            }

            Console.ReadLine();
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
        }

        static void Assign(ref int num, ref string name)
        {
            num = 20;
        }
    }
}
//ref passes by reference of memory address
// difference between an out and a reference is that with an out you have to make use of the value
// with the ref you do not have to make an assignment
// passing by reference is quicker
// when assigning by reference the variable must be made before being passed in,
