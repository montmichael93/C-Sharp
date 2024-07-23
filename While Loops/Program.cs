using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }
            Console.ReadLine();*/

            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("what is the value of + " + numberA + " X " + numberB + "? ");
            Console.WriteLine();


            while (answer != actualAnswer)
            {
                Console.WriteLine("Enter your answer: ");
                string answerInput = Console.ReadLine();
                 actualAnswer = Convert.ToInt32(answerInput);
                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was WRONG!");
                }
 
            }

            Console.WriteLine("Well Done!");

            Console.ReadLine();


        }
    }
}

// for loops is to loop for a certain amount of times and while loops are to loop until a condition is is met
// while loops only have the condition to determine when to stop iterating 