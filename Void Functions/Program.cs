using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            CreateAndPrintArray();

            //the numbers variable won't be accessible here

            Console.ReadLine();
        }

        //because we aren't returning back anything
        static void CreateAndPrintArray()
        {
            int[] numbers = new int[3] { 0, 1, 2 };

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item} ");
            }
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("welcome to my program");
        }
    }
}
