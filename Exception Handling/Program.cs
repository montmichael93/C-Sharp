using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            byte num = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
//Exceptions are used to prevent the code form crashing and closing down
// error are apparently called exceptions, unhandled exceptions appear when the code crashes
// when the exe crashes, all data is lost. 