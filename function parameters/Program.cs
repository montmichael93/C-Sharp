using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(Add(2, 2));

            int num = ReadInt("Enter a number: ");
            Console.WriteLine(num);

            int angle = ReadInt("Enter an angle: ");
            Console.WriteLine(angle);

            Console.ReadLine();
        }

        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        //parameter variables are local variables that only exist in memory
        //once deleted from memory it is no longer accessible
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
