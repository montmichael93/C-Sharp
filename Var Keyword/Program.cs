using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int age = -23;
            //var age; //invalid variable deceleration due to compiler not knowing what the variable type is going to be

            var age = 22;
            Console.WriteLine(age);

            //long bigNumber = 90000000000L;
            var bigNumber = 90000000000;
            Console.WriteLine(bigNumber);

            //double negative = -55.2D;
            var negative = -55.2;
            Console.WriteLine(negative);

            //float precision = 5.000001F;
            var precision = 5.000001;
            Console.WriteLine(precision);

            // decimal money = 14.99M;
            var money = 14.99;
            Console.WriteLine(money);

            var name = "Michael";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);

            Console.ReadLine();
            //Don't have to do this, when the code gets compiled it doesn't matter
            //only use var if it is obvious what the variable is going to be
            //using var too much will hurt the readability of the code because you will need to hover over each one to find out what the type is going to be

        }
    }
}
