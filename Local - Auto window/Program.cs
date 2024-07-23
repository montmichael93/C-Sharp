using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local___Auto_window
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 22;

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


