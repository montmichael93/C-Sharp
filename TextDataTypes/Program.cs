

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ava"; //strings are in double quotes, can store empty string as ""
            char letter = 'a'; // single characters are in single quotes, CAN NOT store empty character as '', gets defaulted as '\0'
            Console.WriteLine("Your name is: ");
            Console.WriteLine(name);
            Console.WriteLine(letter);
            Console.ReadLine();

        }
    }
}
