using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;

            while(success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();
                //TryParse tries to convert a string to a number of the specified type and outputs the converted value to a variable
                                            // the out key word outputs the value to assign to variable if successful 
                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to Convert!");
                }
            }
            Console.ReadLine();
        }
    }
}
