using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] { 1, 2, 3 };

            List<int> listNumbers = new List<int>() { 1, 2, 3 };

            listNumbers.Add(4);
            listNumbers.Add(5);
            listNumbers.Add(6);

            for (int i = 0; i < listNumbers.Count; i++)
            {
                // Console.Write("Enter a number");
                // int num = Convert.ToInt32(Console.ReadLine());
                //listNumbers.Add(num);
                Console.WriteLine(listNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
//Lists are dynamic unlike arrays
//can add, remove and modify
//expanding and array is done by making a new array and adding the old values to it.
//things fetched from a DB are stored in a list
//lists do not have a length
