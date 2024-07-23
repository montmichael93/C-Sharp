using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to count?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (loopCounter <= 0) {
                Console.WriteLine("Sorry, please enter a value above 0");
            } else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }

            }
            Console.ReadLine();
        }
    }
}
//the three parts of a for loop

//1. define the variable that will be used for a for loop counter and give it it's initial value
//2. stopping condition
//3. number of time things get done based on the total elements being iterated on]
