using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 2, 1, 6, 4, 5, 3, 9, 8, 7, };

            string test = "";
            test.Replace(" ", "");

            Array.Sort(number);

            foreach (int num in number)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
