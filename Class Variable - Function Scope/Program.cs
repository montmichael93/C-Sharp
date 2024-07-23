using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Variable___Function_Scope
{
    internal class Program
    {
        static int x = 5;
        static void Main(string[] args)
        {
            Console.WriteLine(x);
            x = 20;
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
