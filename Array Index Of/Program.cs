using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Array_Index_Of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 90, 199, 22, 50, 30 };

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //Array.IndexOf();

            // int position = Array.IndexOf(numbers, search);

            //can be given an index starting and ending position
            //int position = Array.IndexOf(numbers, search, 0, 3);


            Console.WriteLine();

            int position = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    position = i;
                }
            }

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position}");
            }
            else
            {
                Console.WriteLine($"Number {search} as not been found");
            }

            Console.ReadLine();
        }
    }
}
