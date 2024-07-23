using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("what is your name?: "); 
            string name = Console.ReadLine(); 

            Console.Write("what is your age?: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);


            Console.WriteLine();
            Console.WriteLine("Your Name is " + name + " and you are " + age + " years old");

            if (age >= 18 && age <= 25)
            {
                Console.WriteLine();
                Console.WriteLine("you are between 18 and 25");
            }
            else if (age >= 26)
            {
                Console.WriteLine();
                Console.WriteLine("you are 25 or older");
            }
            else if (age <  0 || age > 150) {
                Console.WriteLine();
                Console.WriteLine("Invalid age");
            }
            */

           Console.Write("Enter the first number");
           string numberAInput = Console.ReadLine();
           int numberA = Convert.ToInt32(numberAInput);

           Console.Write("Enter the second number");
           string numberBInput = Console.ReadLine();
           int numberB = Convert.ToInt32(numberBInput);
           
           int answer = numberA * numberB;

           Console.Write("Value of + " + numberA + " X " + numberB + ":  " );
           string answerInput = Console.ReadLine();
           int actualAnswer = Convert.ToInt32(answerInput);

           if (answer == actualAnswer)
            {
                Console.WriteLine("Well Done!");
            } else
            {
                Console.WriteLine("Close but it was WRONG!");
            }


            Console.ReadLine();
        }
    }
}
