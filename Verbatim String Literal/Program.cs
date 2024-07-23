using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbatim_String_Literal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //\t \n \"

            //in a string a single \ is an escape character in a normal sting
            // use \\ in a normal string to write down directories

            //string speech = "She said \"something\"";
            //Console.WriteLine(speech);

            //string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course";

            //Verbatim identifier
            string path;

            path = @"C:\Users\CoffeeNCode\Desktop\C# Course" + "\nNew line test";
            Console.WriteLine(path);

            string greeting = @"Hello ""someone"" ";
            Console.WriteLine(greeting);
         
            Console.ReadLine();

;        }
    }
}

