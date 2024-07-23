using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            do
            {
                Console.WriteLine("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);
                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was WRONG!");
                }

            } while (answer != actualAnswer);


            Console.WriteLine("Well Done!");

            Console.ReadLine();
        }
    }
}

// do while loops always loop once then check the condition at the end
// while loops checks the condition firsts