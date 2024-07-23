using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Error_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter A Number: ");
                byte num = Convert.ToByte(Console.ReadLine());
                Console.WriteLine(num);
            }
            //this custom error message overrides the standard message
            catch (FormatException)
            {
                Console.WriteLine("customer error message");
            }
            //this exceptions is specifically for integer overflows
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a value under 2 billion");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
