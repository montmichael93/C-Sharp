using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices; //need this to access the [Optional]
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5);

            Console.WriteLine(result);

            int pultiplyThem = Multiply(5);

            Console.ReadLine();
        }

        //optional parameter, best to set it as a default value
        static int Add(int a, int b = default)
        {
            return a + b;
        }

        static int Multiply(int a, [Optional] int b) //the default value is 0
        {
            return a * b;
        }
    }
}
