using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    //short hand for string name = ""
            string emptyStringVariable = string.Empty;
            
            Console.WriteLine(emptyStringVariable);

            string name = Console.ReadLine();

            if (name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");
            } else
            {
                Console.WriteLine("Name is Empty");
            }
            
            

            Console.ReadLine();
        }
    }
}
