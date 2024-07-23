using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 35;

            if (age > 18)
            {
                Console.WriteLine("18+");
            } 
            else if (age > 30)
            {
                Console.WriteLine("30+");
            }

            Console.ReadLine();
        }
    }
}
//click all the way to the left of the line to create the debugging red dot
// press F10 to start debugger, press F11 to move to the next debugging line