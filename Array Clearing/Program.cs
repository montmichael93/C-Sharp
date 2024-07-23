using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Clearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //resets all array values into their default type
            //Array.Clear(numbers, 0, numbers.Length);

           // changes values from index 5 and 5 indices after into the default value
           // Array.Clear(numbers, 5, 5); 
            for (int i = 5; i < numbers.Length; i++)
            {
                numbers[i] = default;
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
// can not remove from array, only change value to default value
// can't remove form array