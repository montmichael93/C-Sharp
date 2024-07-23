using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 3;
            //10 / 3 = 3r1
            //3 x 3 = 9, 1 left over to get to 10

            //10 % 2 = 0
            //11 % 2 = 1
            //12 % 2 = 0
            //13 % 2 = 1

            Console.WriteLine(firstNum / secondNum); //will just get 3 because of the value gets truncated.
            //remember: TypeScript does not truncate the value

            Console.WriteLine(firstNum % secondNum); //will get the value of 1

            Console.ReadLine();
        }
    }
}
