using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());


            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please only enter a number less than 2 billion");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter numbers!");
                }
                catch (Exception) //unspecified exception, compiler does not allow this Exception in the beginning of the chain
                {
                    Console.WriteLine("Something has went wrong!");
                }
            }

            Console.ReadLine();
        }
    }
}
